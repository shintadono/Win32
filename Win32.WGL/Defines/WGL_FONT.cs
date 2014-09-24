using System;

namespace Win32.WGL
{
	/// <summary>
	/// Specifying the format to use in display lists.
	/// </summary>
	[Obsolete("Display list aren't supported in the OpenGL core profile anymore.")]
	public enum WGL_FONT : uint
	{
		/// <summary>
		/// Format of the display list will be lines.
		/// </summary>
		LINES=0,

		/// <summary>
		///  Format of the display list will be polygons.
		/// </summary>
		POLYGONS=1,
	}
}
