using System;
using System.Runtime.InteropServices;

namespace Win32.WGL
{
	/// <summary>
	/// Contains the x and y coordinates of a point.
	/// </summary>
	[Obsolete("Display list aren't supported in the OpenGL core profile anymore.")]
	[StructLayout(LayoutKind.Sequential)]
	public struct PointFloat
	{
		/// <summary>
		/// The horizontal (x) coordinate of a point.
		/// </summary>
		public float x;

		/// <summary>
		/// The vertical (y) coordinate of a point.
		/// </summary>
		public float y;
	}
}
