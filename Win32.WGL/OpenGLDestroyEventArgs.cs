using System;

namespace Win32.WGL
{
	/// <summary>
	/// Event arguments for OpenGL destruction.
	/// </summary>
	public class OpenGLDestroyEventArgs : EventArgs
	{
		/// <summary>
		/// <b>true</b> if the OpenGL is not current. (Called on <see cref="WM.DESTROY"/>, but device context already destroyed.)
		/// </summary>
		public bool Error;

		/// <summary>
		/// Construct an instance of <see cref="OpenGLDestroyEventArgs"/>.
		/// </summary>
		/// <param name="error">A <b>bool</b> specifying whether the rendering context could be made current.</param>
		public OpenGLDestroyEventArgs(bool error) { Error=error; }
	}
}
