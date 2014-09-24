using System;
using System.Runtime.InteropServices;

namespace Win32.WGL
{
	/// <summary>
	/// Contains information about the placement and orientation of a glyph in a character cell.
	/// </summary>
	[Obsolete("Display list aren't supported in the OpenGL core profile anymore.")]
	[StructLayout(LayoutKind.Sequential)]
	public struct GlyphMetricsFloat
	{
		/// <summary>
		/// The width of the smallest rectangle (the glyph's black box) that completely encloses the glyph.
		/// </summary>
		public float gmfBlackBoxX;

		/// <summary>
		/// The height of the smallest rectangle (the glyph's black box) that completely encloses the glyph.
		/// </summary>
		public float gmfBlackBoxY;

		/// <summary>
		/// The x and y coordinates of the upper-left corner of the smallest rectangle that completely encloses the glyph.
		/// </summary>
		public PointFloat gmfptGlyphOrigin;

		/// <summary>
		/// The horizontal distance from the origin of the current character cell to the origin of the next character cell.
		/// </summary>
		public float gmfCellIncX;

		/// <summary>
		/// The vertical distance from the origin of the current character cell to the origin of the next character cell.
		/// </summary>
		public float gmfCellIncY;
	}
}
