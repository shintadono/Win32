using System;
using System.Security.Permissions;
using System.Windows.Forms;
using HDC=System.IntPtr;
using HGLRC=System.IntPtr;

namespace Win32.WGL
{
	partial class OpenGLControl
	{
		/// <summary>
		/// Overrides the window procedure to handle <see cref="WM.DESTROY"/>, <see cref="WM.PAINT"/> and <see cref="WM.ERASEBKGND"/> messages.
		/// </summary>
		/// <param name="m">The message.</param>
		[PermissionSet(SecurityAction.Demand, Name="FullTrust")]
		protected override void WndProc(ref Message m)
		{
			switch(m.Msg)
			{
				case WM.DESTROY:
					{
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
					break;
				case WM.PAINT:
					Invalidate();
					break;
				case WM.ERASEBKGND: return; // Speed up the handling. This is not needed for OpenGL.
			}
			base.WndProc(ref m);
		}

		/// <summary>Clean up any resources being used.</summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			this.AutoScaleDimensions=new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.Name="Win32.OpenGLControl";
			this.ResumeLayout(false);
		}
		#endregion
	}
}
