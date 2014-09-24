namespace Win32.WGL
{
	/// <summary>
	/// Specifies pixel types for pixel formats.
	/// </summary>
	public enum wglPixelTypeARB : int
	{
		/// <summary>
		/// RGBA.
		/// </summary>
		RGBA_ARB=0x202B,

		/// <summary>
		/// Paletted/indexed colors. Not supported be the OpenGL core profile.
		/// </summary>
		COLORINDEX_ARB=0x202C,

		#region WGL_ARB_pixel_format_float
		/// <summary>
		/// Floating point RGBA.
		/// </summary>
		RGBA_FLOAT_ARB=0x21A0,
		#endregion

		#region WGL_EXT_pixel_format_packed_float
		/// <summary>
		/// Unsigned floating points RGBA.
		/// </summary>
		RGBA_UNSIGNED_FLOAT_EXT=0x20A8,
		#endregion
	}
}
