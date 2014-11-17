namespace Win32
{
	/// <summary>
	/// The output quality.
	/// </summary>
	public enum QUALITY : uint
	{
		/// <summary>
		/// Appearance of the font does not matter.
		/// </summary>
		DEFAULT=0,

		/// <summary>
		/// Appearance of the font is less important than when the <see cref="PROOF"/> value is used.
		/// </summary>
		DRAFT=1,

		/// <summary>
		/// Character quality of the font is more important than exact matching of the logical-font attributes.
		/// </summary>
		PROOF=2,

		/// <summary>
		/// Font is never antialiased, that is, font smoothing is not done.
		/// </summary>
		NONANTIALIASED=3,

		/// <summary>
		/// Font is antialiased, or smoothed, if the font supports it and the size of the font is not too small or too large.
		/// </summary>
		ANTIALIASED=4,

		/// <summary>
		/// If set, text is rendered (when possible) using ClearType antialiasing method.
		/// </summary>
		CLEARTYPE=5,

		/// <summary>
		/// ?
		/// </summary>
		CLEARTYPE_NATURAL=6,
	}
}
