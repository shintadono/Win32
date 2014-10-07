namespace Win32
{
	/// <summary>
	/// <see cref="O:Win32.Font.GetGlyphOutline">GetGlyphOutline</see> constants.
	/// </summary>
	public enum GGO : uint
	{
		/// <summary>
		/// Only retrieves the <see cref="GlyphMetrics"/> structure.
		/// </summary>
		METRICS=0,

		/// <summary>
		/// The function retrieves the glyph bitmap. For information about memory allocation, see the following Remarks section.
		/// </summary>
		BITMAP=1,

		/// <summary>
		/// The function retrieves the curve data points in the rasterizer's native format and uses the font's design units.
		/// </summary>
		NATIVE=2,

		/// <summary>
		/// The function retrieves the curve data as a cubic Bézier spline (not in quadratic spline format).
		/// </summary>
		BEZIER=3,

		/// <summary>
		/// The function retrieves a glyph bitmap that contains five levels of gray.
		/// </summary>
		GRAY2_BITMAP=4,

		/// <summary>
		/// The function retrieves a glyph bitmap that contains 17 levels of gray.
		/// </summary>
		GRAY4_BITMAP=5,

		/// <summary>
		/// The function retrieves a glyph bitmap that contains 65 levels of gray.
		/// </summary>
		GRAY8_BITMAP=6,

		/// <summary>
		/// Indicates that the <b>uChar</b> parameter of <see cref="O:Win32.Font.GetGlyphOutline">GetGlyphOutline</see> is a TrueType Glyph Index rather than a character code.
		/// </summary>
		GLYPH_INDEX=0x0080,

		/// <summary>
		/// The function only returns unhinted outlines. This flag only works in conjunction with <see cref="BEZIER"/> and <see cref="NATIVE"/>.
		/// </summary>
		UNHINTED=0x0100,
	}
}
