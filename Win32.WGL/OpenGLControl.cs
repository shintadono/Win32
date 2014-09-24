using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using OpenGL.Core;
using HDC=System.IntPtr;
using HGLRC=System.IntPtr;

namespace Win32.WGL
{
	/// <summary>
	/// Control for rendering in OpenGL.
	/// </summary>
	/// <remarks>
	/// <para>After creating the control is in a 'raw' state. To render you'll have to create a render context,
	/// make the context current, set up the viewport and buffer swaps yourself. No <see cref="Render"/> and
	/// <see cref="Error"/> events will be raised. You can do all of this if you implement a <b>Paint</b> event handler.</para>
	/// <para>When you use one of the <b>Setup</b> methods, the control will create a render context, make it current,
	/// set up the viewport before the <see cref="Render"/> event is raised. The <see cref="Error"/> event will
	/// be raised on errors while rendering and the context released (made not current) afterward. The buffer swaps will
	/// be done if <see cref="DoDoubleBufferSwaps"/> is set, if specified to the <b>Setup</b> method. The control
	/// can only be set up once, no changes a possible afterwards. Use <see cref="DrawScene"/> to start the render.
	/// This should be done in the <b>Paint</b> event handler.</para>
	/// <example>
	///	using Win32.WGL; // for wgl and control
	///	using OpenGL.Core; // for gl
	///
	///	public Form()
	///	{
	///		// Load the wgl extensions. openGLControl.Setup will crash if not done before it's call.
	///		if(!wgl.LoadWGLExtensions()) throw new NotSupportedException("Error loading wgl-extensions.");
	///
	///		InitializeComponent();
	///
	///		// We need depth and stencil buffer, stereo is not necessary.
	///		if(!openGLControl.Setup(DontCareBool.TRUE, DontCareBool.TRUE, DontCareBool.FALSE)) throw new NotSupportedException("Error initializing OpenGL render context.");
	///
	///		// Make rendering context current in this thread.
	///		if(!wgl.MakeCurrent(openGLControl.DC, openGLControl.RC)) throw new NotSupportedException("Error activating OpenGL render context.");
	///
	///		// Load the OpenGL extension.
	///		gl.LoadOpenGL();
	///
	///		// Check if the necessary support is available.
	///		if(!gl.VERSION_4_0) throw new NotSupportedException("Error initializing OpenGL 4 extensions.");
	///
	///		// Make rendering context not-current in this thread.
	///		if(!wgl.MakeCurrent(IntPtr.Zero, IntPtr.Zero)) throw new NotSupportedException("Error activating OpenGL render context.");
	///	}
	/// </example>
	/// </remarks>
	public partial class OpenGLControl : UserControl
	{
		/// <summary>
		/// Handler for OpenGLControl <see cref="Error"/> events.
		/// </summary>
		/// <param name="sender">The control the event was raised for.</param>
		/// <param name="e">A <see cref="OpenGLErrorEventArgs"/> containing the OpenGL error code.</param>
		public delegate void ErrorEventHandler(object sender, OpenGLErrorEventArgs e);

		/// <summary>
		/// Handler for OpenGLControl <see cref="Render"/> events.
		/// </summary>
		/// <param name="sender">The control the event was raised for.</param>
		/// <param name="e">An instance of <see cref="EventArgs"/>.</param>
		public delegate void RenderEventHandler(object sender, EventArgs e);

		/// <summary>
		/// Handler for OpenGLControl <see cref="Destroy"/> events. This event is raised on
		/// destruction of the control, or when calling <see cref="PreDestoryCleanUp"/>;
		/// </summary>
		/// <param name="sender">The control the event was raised for.</param>
		/// <param name="e">An instance of <see cref="EventArgs"/>.</param>
		public delegate void DestroyEventHandler(object sender, OpenGLDestroyEventArgs e);

		/// <summary>
		/// This event will be raised, if an OpenGL error occured while rendering.
		/// </summary>
		[CategoryAttribute("Action")]
		[DescriptionAttribute("Action")]
		public event ErrorEventHandler Error;

		/// <summary>
		/// This event will be raised, when the content of the control needs to be refreshed.
		/// </summary>
		[CategoryAttribute("Action")]
		[DescriptionAttribute("Action")]
		public event RenderEventHandler Render;

		/// <summary>
		/// This event will be raised, when the control gets destroyed.
		/// </summary>
		[CategoryAttribute("Action")]
		[DescriptionAttribute("Action")]
		public event DestroyEventHandler Destroy;

		#region Ctor and Initialization
		/// <summary>
		/// Constructes a new instance of this class.
		/// </summary>
		public OpenGLControl()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint|ControlStyles.Opaque|ControlStyles.ResizeRedraw|ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, false);

			DC=HDC.Zero;
			RC=HGLRC.Zero;
			IsStereo=false;
			StencilBits=0;
			DepthBits=0;

			InitializeComponent();
		}

		/// <summary>
		/// Adds the class styles <see cref="CS.VREDRAW"/>, <see cref="CS.HREDRAW"/> and <see cref="CS.OWNDC"/> to support OpenGL rendering.
		/// </summary>
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp=base.CreateParams;
				cp.ClassStyle|=CS.VREDRAW|CS.HREDRAW|CS.OWNDC;
				// TODO cp.Style|=WS.CLIPCHILDREN|WS.CLIPSIBLINGS;
				return cp;
			}
		}
		#endregion

		#region Focus handling
		/// <summary>
		/// Returns wether or not the control has the focus.
		/// </summary>
		public bool HasFocus { get; private set; }

		/// <summary>
		/// Overrides the OnGotFocus method to get informations of the current focus position. Invalidates the control if focus changes.
		/// </summary>
		/// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);

			HasFocus=true;
			Invalidate();
		}

		/// <summary>
		/// Overrides the OnLostFocus method to get informations of the current focus position. Invalidates the control if focus changes.
		/// </summary>
		/// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);

			HasFocus=false;
			Invalidate();
		}
		#endregion

		#region Paint Events
		/// <summary>
		/// When this methode gets called, the content of the control needs to be refreshed. This will be done by raising the <see cref="Render"/> event.
		/// </summary>
		/// <param name="e">A <see cref="PaintEventArgs"/> with all necessary informations and instances of <see cref="Graphics"/> to do our GDI drawing in <see cref="Component.DesignMode"/>.</param>
		protected override void OnPaint(PaintEventArgs e)
		{
			if(e==null) throw new ArgumentNullException("e", "PaintEventArgs of OnPaint methode must not be null.");

			if(DesignMode)
			{
				e.Graphics.Clear(Color.Black);

				StringFormat sf=new StringFormat(StringFormatFlags.NoClip);
				sf.Alignment=StringAlignment.Center;
				sf.LineAlignment=StringAlignment.Center;

				e.Graphics.DrawString("OpenGL Control\nDesignMode", SystemFonts.DefaultFont, Brushes.WhiteSmoke, Width/2f, Height/2f, sf);
				e.Graphics.Flush();

				return;
			}

			base.OnPaint(e);
		}

		/// <summary>
		/// This override is not needed since <see cref="ControlStyles.Opaque"/> is set. It is still overwritten to be on the safe side.
		/// </summary>
		/// <param name="e">A <see cref="PaintEventArgs"/> with all necessary informations and instances of <see cref="Graphics"/> to do our background cleaning.</param>
		protected override void OnPaintBackground(PaintEventArgs e) { }
		#endregion

		#region Drawing
		/// <summary>
		/// Starts the renderer.
		/// </summary>
		public void DrawScene()
		{
			if(RC==HGLRC.Zero) throw new Exception("OpenGLControl still in raw state. You have to call one of the 'Setup' methods before using 'DrawScene'.");

			if(Width==0||Height==0) return;

			wgl.MakeCurrent(DC, RC);

			gl.Viewport(0, 0, Width, Height);

			RenderEventHandler render=Render;
			if(render!=null) render(this, EventArgs.Empty);

			gl.Flush();

			ErrorEventHandler error=Error;
			if(error!=null)
			{
				glErrorCode errorCode=gl.GetError();
				if(errorCode!=glErrorCode.NO_ERROR) error(this, new OpenGLErrorEventArgs(errorCode));
			}

			wgl.MakeCurrent(HDC.Zero, HGLRC.Zero);

			if(DoDoubleBufferSwaps) DeviceContext.SwapBuffers(DC);
		}
		#endregion

		#region Other Events
		/// <summary>
		/// Overrides the IsInputKey method to add the direction keys to the regular input keys.
		/// </summary>
		/// <param name="keyData">One of the Keys values. </param>
		/// <returns><b>true</b> if the specified key is a regular input key, otherwise <b>false</b> is returned.</returns>
		protected override bool IsInputKey(Keys keyData)
		{
			if((keyData&Keys.KeyCode)==Keys.Up) return true;
			if((keyData&Keys.KeyCode)==Keys.Right) return true;
			if((keyData&Keys.KeyCode)==Keys.Left) return true;
			if((keyData&Keys.KeyCode)==Keys.Down) return true;

			return base.IsInputKey(keyData);
		}
		#endregion

		#region Setup
		static Dictionary<wglPixelFormatAttributeARB, object> MakePixelFormatAttributes(DontCareBool depth24Bits=DontCareBool.DONT_CARE, DontCareBool stencil8Bits=DontCareBool.DONT_CARE, DontCareBool stereo=DontCareBool.DONT_CARE)
		{
			Dictionary<wglPixelFormatAttributeARB, object> pixelFormatAttributes=new Dictionary<wglPixelFormatAttributeARB, object>();
			pixelFormatAttributes.Add(wglPixelFormatAttributeARB.DRAW_TO_WINDOW_ARB, true);
			pixelFormatAttributes.Add(wglPixelFormatAttributeARB.ACCELERATION_ARB, wglAccelerationModeARB.FULL_ACCELERATION_ARB);
			pixelFormatAttributes.Add(wglPixelFormatAttributeARB.SUPPORT_OPENGL_ARB, true);
			pixelFormatAttributes.Add(wglPixelFormatAttributeARB.DOUBLE_BUFFER_ARB, true);
			pixelFormatAttributes.Add(wglPixelFormatAttributeARB.PIXEL_TYPE_ARB, wglPixelTypeARB.RGBA_ARB);
			pixelFormatAttributes.Add(wglPixelFormatAttributeARB.COLOR_BITS_ARB, 24);

			//pixelFormatAttributes.Add(wglPixelFormatAttributeARB.RED_BITS_ARB, 8);
			//pixelFormatAttributes.Add(wglPixelFormatAttributeARB.GREEN_BITS_ARB, 8);
			//pixelFormatAttributes.Add(wglPixelFormatAttributeARB.BLUE_BITS_ARB, 8);
			//pixelFormatAttributes.Add(wglPixelFormatAttributeARB.ALPHA_BITS_ARB, 8);

			if(depth24Bits!=DontCareBool.DONT_CARE) pixelFormatAttributes.Add(wglPixelFormatAttributeARB.DEPTH_BITS_ARB, depth24Bits==DontCareBool.TRUE?24:0);
			if(stencil8Bits!=DontCareBool.DONT_CARE) pixelFormatAttributes.Add(wglPixelFormatAttributeARB.STENCIL_BITS_ARB, stencil8Bits==DontCareBool.TRUE?8:0);
			if(stereo!=DontCareBool.DONT_CARE) pixelFormatAttributes.Add(wglPixelFormatAttributeARB.STEREO_ARB, stereo==DontCareBool.TRUE);

			return pixelFormatAttributes;
		}

		static Dictionary<wglContextAttributeARB, object> MakeContextAttributes(int minMajorVerion=4, int minMinorVersion=4)
		{
			Dictionary<wglContextAttributeARB, object> contextAttributes=new Dictionary<wglContextAttributeARB, object>();
			contextAttributes.Add(wglContextAttributeARB.CONTEXT_MAJOR_VERSION_ARB, minMajorVerion);
			contextAttributes.Add(wglContextAttributeARB.CONTEXT_MINOR_VERSION_ARB, minMinorVersion);
			return contextAttributes;
		}

		/// <summary>
		/// Initializes the control to the OpenGL-ready-to-use state, by setting up the device and rendering context. This can only be done once!
		/// </summary>
		/// <param name="depth24Bits">A <see cref="DontCareBool"/> specifying the need for (minimum) 24 depth buffer bits.</param>
		/// <param name="stencil8Bits">A <see cref="DontCareBool"/> specifying the need for (minimum) 8 stencil buffer bits.</param>
		/// <param name="stereo">A <see cref="DontCareBool"/> specifying the need for Stereo support.</param>
		/// <param name="minMajorVerion">The minimal major OpenGL version the rendering context shall support.</param>
		/// <param name="minMinorVersion">The minimal minor OpenGL version the rendering context shall support.</param>
		/// <returns><b>true</b> if control was successfully set up, otherwise <b>false</b> is returned.</returns>
		public virtual bool Setup(DontCareBool depth24Bits=DontCareBool.DONT_CARE, DontCareBool stencil8Bits=DontCareBool.DONT_CARE, DontCareBool stereo=DontCareBool.DONT_CARE,
			int minMajorVerion=4, int minMinorVersion=4)
		{
			if(RC!=HGLRC.Zero) return true; // already done
			return Setup(HGLRC.Zero, MakePixelFormatAttributes(depth24Bits, stencil8Bits, stereo), MakeContextAttributes(minMajorVerion, minMinorVersion));
		}

		/// <summary>
		/// Initializes the control to the OpenGL-ready-to-use state, by setting up the device and rendering context. This can only be done once!
		/// </summary>
		/// <param name="shareRC">The handle of the rendering context to share lists with.</param>
		/// <param name="depth24Bits">A <see cref="DontCareBool"/> specifying the need for (minimum) 24 depth buffer bits.</param>
		/// <param name="stencil8Bits">A <see cref="DontCareBool"/> specifying the need for (minimum) 8 stencil buffer bits.</param>
		/// <param name="stereo">A <see cref="DontCareBool"/> specifying the need for Stereo support.</param>
		/// <param name="minMajorVerion">The minimal major OpenGL version the rendering context shall support.</param>
		/// <param name="minMinorVersion">The minimal minor OpenGL version the rendering context shall support.</param>
		/// <returns><b>true</b> if control was successfully set up, otherwise <b>false</b> is returned.</returns>
		public virtual bool Setup(HGLRC shareRC, DontCareBool depth24Bits=DontCareBool.DONT_CARE, DontCareBool stencil8Bits=DontCareBool.DONT_CARE, DontCareBool stereo=DontCareBool.DONT_CARE,
			int minMajorVerion=4, int minMinorVersion=4)
		{
			if(RC!=HGLRC.Zero) return true; // already done
			return Setup(shareRC, MakePixelFormatAttributes(depth24Bits, stencil8Bits, stereo), MakeContextAttributes(minMajorVerion, minMinorVersion));
		}

		/// <summary>
		/// Initializes the control to the OpenGL-ready-to-use state, by setting up the device and rendering context. This can only be done once!
		/// </summary>
		/// <param name="pixelFormatAttributes">The dictionary of attributes used to specify the pixel format.</param>
		/// <param name="minMajorVerion">The minimal major OpenGL version the rendering context shall support.</param>
		/// <param name="minMinorVersion">The minimal minor OpenGL version the rendering context shall support.</param>
		/// <returns><b>true</b> if control was successfully set up, otherwise <b>false</b> is returned.</returns>
		public virtual bool Setup(Dictionary<wglPixelFormatAttributeARB, object> pixelFormatAttributes, int minMajorVerion=4, int minMinorVersion=4)
		{
			if(RC!=HGLRC.Zero) return true; // already done
			return Setup(HGLRC.Zero, pixelFormatAttributes, MakeContextAttributes(minMajorVerion, minMinorVersion));
		}

		/// <summary>
		/// Initializes the control to the OpenGL-ready-to-use state, by setting up the device and rendering context. This can only be done once!
		/// </summary>
		/// <param name="shareRC">The handle of the rendering context to share lists with.</param>
		/// <param name="pixelFormatAttributes">The dictionary of attributes used to specify the pixel format.</param>
		/// <param name="minMajorVerion">The minimal major OpenGL version the rendering context shall support.</param>
		/// <param name="minMinorVersion">The minimal minor OpenGL version the rendering context shall support.</param>
		/// <returns><b>true</b> if control was successfully set up, otherwise <b>false</b> is returned.</returns>
		public virtual bool Setup(HGLRC shareRC, Dictionary<wglPixelFormatAttributeARB, object> pixelFormatAttributes, int minMajorVerion=4, int minMinorVersion=4)
		{
			if(RC!=HGLRC.Zero) return true; // already done
			return Setup(shareRC, pixelFormatAttributes, MakeContextAttributes(minMajorVerion, minMinorVersion));
		}

		/// <summary>
		/// Initializes the control to the OpenGL-ready-to-use state, by setting up the device and rendering context. This can only be done once!
		/// </summary>
		/// <param name="pixelFormatAttributes">The dictionary of attributes used to specify the pixel format.</param>
		/// <param name="contextAttributes">The dictionary of attributes used to specify the rendering context.</param>
		/// <returns><b>true</b> if control was successfully set up, otherwise <b>false</b> is returned.</returns>
		public virtual bool Setup(Dictionary<wglPixelFormatAttributeARB, object> pixelFormatAttributes, Dictionary<wglContextAttributeARB, object> contextAttributes)
		{
			return Setup(HGLRC.Zero, pixelFormatAttributes, contextAttributes);
		}

		/// <summary>
		/// Initializes the control to the OpenGL-ready-to-use state, by setting up the device and rendering context. This can only be done once!
		/// </summary>
		/// <param name="shareRC">The handle of the rendering context to share lists with.</param>
		/// <param name="pixelFormatAttributes">The dictionary of attributes used to specify the pixel format.</param>
		/// <param name="contextAttributes">The dictionary of attributes used to specify the rendering context.</param>
		/// <returns><b>true</b> if control was successfully set up, otherwise <b>false</b> is returned.</returns>
		public virtual bool Setup(HGLRC shareRC, Dictionary<wglPixelFormatAttributeARB, object> pixelFormatAttributes, Dictionary<wglContextAttributeARB, object> contextAttributes)
		{
			if(RC!=HGLRC.Zero) return true; // already done
			if(pixelFormatAttributes==null) throw new ArgumentNullException("pixelFormatAttributes");
			if(contextAttributes==null) throw new ArgumentNullException("contextAttributes");

			DC=Window.GetDC(Handle);
			if(DC==IntPtr.Zero) return false;

			int pixelFormat;
			if(!wgl.ChoosePixelFormatARB(DC, pixelFormatAttributes, out pixelFormat))
			{
				Window.ReleaseDC(Handle, DC);
				DC=HDC.Zero;
				return false;
			}

			return Setup(shareRC, pixelFormat, contextAttributes);
		}

		/// <summary>
		/// Initializes the control to the OpenGL-ready-to-use state, by setting up the device and rendering context. This can only be done once!
		/// </summary>
		/// <param name="pixelFormat">The pixel format to use.</param>
		/// <param name="minMajorVerion">The minimal major OpenGL version the rendering context shall support.</param>
		/// <param name="minMinorVersion">The minimal minor OpenGL version the rendering context shall support.</param>
		/// <returns><b>true</b> if control was successfully set up, otherwise <b>false</b> is returned.</returns>
		public virtual bool Setup(int pixelFormat, int minMajorVerion=4, int minMinorVersion=4)
		{
			if(RC!=HGLRC.Zero) return true; // already done
			return Setup(HGLRC.Zero, pixelFormat, MakeContextAttributes(minMajorVerion, minMinorVersion));
		}

		/// <summary>
		/// Initializes the control to the OpenGL-ready-to-use state, by setting up the device and rendering context. This can only be done once!
		/// </summary>
		/// <param name="shareRC">The handle of the rendering context to share lists with.</param>
		/// <param name="pixelFormat">The pixel format to use.</param>
		/// <param name="minMajorVerion">The minimal major OpenGL version the rendering context shall support.</param>
		/// <param name="minMinorVersion">The minimal minor OpenGL version the rendering context shall support.</param>
		/// <returns><b>true</b> if control was successfully set up, otherwise <b>false</b> is returned.</returns>
		public virtual bool Setup(HGLRC shareRC, int pixelFormat, int minMajorVerion=4, int minMinorVersion=4)
		{
			if(RC!=HGLRC.Zero) return true; // already done
			return Setup(shareRC, pixelFormat, MakeContextAttributes(minMajorVerion, minMinorVersion));
		}

		/// <summary>
		/// Initializes the control to the OpenGL-ready-to-use state, by setting up the device and rendering context. This can only be done once!
		/// </summary>
		/// <param name="pixelFormat">The pixel format to use.</param>
		/// <param name="contextAttributes">The dictionary of attributes used to specify the rendering context.</param>
		/// <returns><b>true</b> if control was successfully set up, otherwise <b>false</b> is returned.</returns>
		public virtual bool Setup(int pixelFormat, Dictionary<wglContextAttributeARB, object> contextAttributes)
		{
			if(RC!=HGLRC.Zero) return true; // already done
			return Setup(HGLRC.Zero, pixelFormat, contextAttributes);
		}

		/// <summary>
		/// Initializes the control to the OpenGL-ready-to-use state, by setting up the device and rendering context. This can only be done once!
		/// </summary>
		/// <param name="shareRC">The handle of the rendering context to share lists with.</param>
		/// <param name="pixelFormat">The pixel format to use.</param>
		/// <param name="contextAttributes">The dictionary of attributes used to specify the rendering context.</param>
		/// <returns><b>true</b> if control was successfully set up, otherwise <b>false</b> is returned.</returns>
		public virtual bool Setup(HGLRC shareRC, int pixelFormat, Dictionary<wglContextAttributeARB, object> contextAttributes)
		{
			if(RC!=HGLRC.Zero) return true; // already done
			if(pixelFormat<1) throw new ArgumentException("Must be greate than zero.", "pixelFormat");
			if(contextAttributes==null) throw new ArgumentNullException("contextAttributes");

			if(DC==HDC.Zero)
			{
				DC=Window.GetDC(Handle);
				if(DC==IntPtr.Zero) return false;
			}

			PixelFormatDescriptor pfd=new PixelFormatDescriptor(PFD.Default);
			if(!DeviceContext.SetPixelFormat(DC, pixelFormat, ref pfd))
			{
				Window.ReleaseDC(Handle, DC);
				DC=HDC.Zero;
				return false;
			}

			int[] values=new int[3];
			wgl.GetPixelFormatAttribivARB(DC, pixelFormat, 0, new wglPixelFormatAttributeARB[] { wglPixelFormatAttributeARB.STEREO_ARB, wglPixelFormatAttributeARB.STENCIL_BITS_ARB, wglPixelFormatAttributeARB.DEPTH_BITS_ARB }, values);

			IsStereo=values[0]!=0;
			StencilBits=values[1];
			DepthBits=values[2];

			RC=wgl.CreateContextAttribsARB(DC, shareRC, contextAttributes);
			if(RC==HGLRC.Zero)
			{
				Window.ReleaseDC(Handle, DC);
				DC=HDC.Zero;
				return false;
			}
			return true;
		}
		#endregion

		#region PreDestoryCleanUp
		/// <summary>
		/// Destroyes the rendering context and releases the device context.
		/// Calls <see cref="Destroy"/> before destroying the rendering context, if set.
		/// </summary>
		public void PreDestoryCleanUp()
		{
			if(RC==HGLRC.Zero) throw new Exception("OpenGLControl still/again in raw state. No pre-destory clean up possible.");

			DestroyEventHandler destroy=Destroy;
			if(destroy!=null)
			{
				bool err=false;
				if(RC!=HGLRC.Zero) err=wgl.MakeCurrent(DC, RC);
				destroy(this, new OpenGLDestroyEventArgs(!err));
				if(RC!=HGLRC.Zero) wgl.MakeCurrent(HDC.Zero, HGLRC.Zero);
			}

			if(RC!=HGLRC.Zero)
			{
				wgl.DeleteContext(RC);
				RC=HGLRC.Zero;
			}

			if(DC!=HDC.Zero)
			{
				Window.ReleaseDC(Handle, DC);
				DC=HDC.Zero;
			}
		}
		#endregion

		#region None-raw-state variables/properties
		/// <summary>
		/// If the control is set up (not in the 'raw' state anymore), this property holds the handle to the device context of the control.
		/// </summary>
		/// <value>The handle to the control's device context.</value>
		public HDC DC { get; private set; }

		/// <summary>
		/// If the control is set up (not in the 'raw' state anymore), this property holds the handle to the rendering context of the control.
		/// </summary>
		/// <value>The handle to the control's rendering context.</value>
		public HGLRC RC { get; private set; }

		/// <summary>
		/// If the control is set up (not in the 'raw' state anymore), this property tells, if stereo is enabled.
		/// </summary>
		/// <value><b>true</b> if stereo is enabled.</value>
		public bool IsStereo { get; private set; }

		/// <summary>
		/// If the control is set up (not in the 'raw' state anymore), this property tells the number of stencil bits available.
		/// </summary>
		/// <value>The number of stencil bits.</value>
		public int StencilBits { get; private set; }

		/// <summary>
		/// If the control is set up (not in the 'raw' state anymore), this property tells the number of depth bit available.
		/// </summary>
		/// <value>The number of depth bits.</value>
		public int DepthBits { get; private set; }

		/// <summary>
		/// If the control is set up (not in the 'raw' state anymore), this gets or sets the double buffer swapping behaviour.
		/// </summary>
		public bool DoDoubleBufferSwaps=true;
		#endregion
	}
}
