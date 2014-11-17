using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// The <b>GlyphMetrics</b> structure contains information about the placement and orientation of a glyph in a character cell.
	/// </summary>
	/// <remarks>
	/// Values in the <b>GlyphMetrics</b> structure are specified in device units.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public struct GlyphMetrics
	{
		/// <summary>
		/// The width of the smallest rectangle that completely encloses the glyph (its black box).
		/// </summary>
		public uint gmBlackBoxX;

		/// <summary>
		/// The height of the smallest rectangle that completely encloses the glyph (its black box).
		/// </summary>
		public uint gmBlackBoxY;

		/// <summary>
		/// The x- and y-coordinates of the upper left corner of the smallest rectangle that completely encloses the glyph.
		/// </summary>
		public Point gmptGlyphOrigin;

		/// <summary>
		/// The horizontal distance from the origin of the current character cell to the origin of the next character cell.
		/// </summary>
		public short gmCellIncX;

		/// <summary>
		/// The vertical distance from the origin of the current character cell to the origin of the next character cell.
		/// </summary>
		public short gmCellIncY;
	}
}
