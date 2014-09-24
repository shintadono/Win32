using System;
using System.Windows.Forms;
using HDC=System.IntPtr;
using HGLRC=System.IntPtr;

namespace Win32.WGL
{
	class wglInitializationDummyWindow : Form
	{
		public bool Success=false;

		public wglInitializationDummyWindow()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint|ControlStyles.Opaque|ControlStyles.ResizeRedraw|ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, false);

			HDC dc=Window.GetDC(Handle);
			if(dc==HDC.Zero) throw new NotSupportedException("OpenGL not supported. Couldn't get device context.");

			try
			{
				PixelFormatDescriptor pfd=new PixelFormatDescriptor(PFD.Default);
				int pixelFormat=DeviceContext.ChoosePixelFormat(dc, ref pfd);
				if(pixelFormat==0) throw new NotSupportedException("OpenGL not supported. Can't find a pixel format.");

				PixelFormatDescriptor checkpfd=new PixelFormatDescriptor();
				if(DeviceContext.DescribePixelFormat(dc, pixelFormat, pfd.nSize, out checkpfd)==0) throw new NotSupportedException("OpenGL not supported. Couldn't retrieve informations about a pixel format.");
				if(checkpfd.dwFlags.HasFlag(PFD.GENERIC_FORMAT))
				{
					// First pixel format should be a ICD. Generic implentation comes later.
					checkpfd=new PixelFormatDescriptor();
					if(DeviceContext.DescribePixelFormat(dc, 1, pfd.nSize, out checkpfd)==0) throw new NotSupportedException("OpenGL not supported. Couldn't retrieve informations about a pixel format.");
					if(checkpfd.dwFlags.HasFlag(PFD.GENERIC_FORMAT)) throw new NotSupportedException("OpenGL not supported. Not ICD (hardware renderer) found.");

					pixelFormat=1;
					pfd=checkpfd;
				}

				if(!DeviceContext.SetPixelFormat(dc, pixelFormat, ref pfd)) throw new NotSupportedException("OpenGL not supported. Couldn't initialize pixel format.");

				HGLRC rc=wgl.CreateContext(dc);
				if(rc==HGLRC.Zero) throw new NotSupportedException("OpenGL not supported. Couldn't create render context.");

				try
				{
					if(!wgl.MakeCurrent(dc, rc)) throw new NotSupportedException("OpenGL not supported. Couldn't make render and device context current.");

					Success=wgl.LoadWGLExtensions(true); // we are already in the window, so no dummy window necessary.

					if(!wgl.MakeCurrent(HDC.Zero, HGLRC.Zero)) throw new NotSupportedException("OpenGL not supported. Couldn't release render and device context from current thread.");
				}
				finally
				{
					if(!wgl.DeleteContext(rc)) throw new NotSupportedException("OpenGL not supported. Couldn't destroy render context.");
				}
			}
			finally
			{
				if(Window.ReleaseDC(Handle, dc)==0) throw new NotSupportedException("OpenGL not supported. Couldn't release device context.");
			}
		}

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp=base.CreateParams;
				cp.ClassStyle|=CS.VREDRAW|CS.HREDRAW|CS.OWNDC;
				cp.Style|=WS.CLIPCHILDREN|WS.CLIPSIBLINGS;
				return cp;
			}
		}
	}
}
