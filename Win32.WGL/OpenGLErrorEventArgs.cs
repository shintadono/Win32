using System;
using OpenGL.Core;

namespace Win32.WGL
{
	/// <summary>
	/// Event arguments for OpenGL error handling.
	/// </summary>
	public class OpenGLErrorEventArgs : EventArgs
	{
		/// <summary>
		/// The error code as <see cref="glErrorCode"/>.
		/// </summary>
		public glErrorCode Error;

		/// <summary>
		/// Construct an instance of <see cref="OpenGLErrorEventArgs"/>.
		/// </summary>
		/// <param name="error">A <see cref="glErrorCode"/> specifying the error code.</param>
		public OpenGLErrorEventArgs(glErrorCode error) { Error=error; }
	}
}
