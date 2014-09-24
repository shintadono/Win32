namespace Win32
{
	/// <summary>
	/// Specifies how TrueType fonts should be printed.
	/// </summary>
	public enum DMTT : uint
	{
		/// <summary>
		/// Print TT fonts as graphics.
		/// </summary>
		BITMAP=1,

		/// <summary>
		/// Download TT fonts as soft fonts.
		/// </summary>
		DOWNLOAD=2,

		/// <summary>
		/// Substitute device fonts for TT fonts.
		/// </summary>
		SUBDEV=3,

		/// <summary>
		/// Download TT fonts as outline soft fonts.
		/// </summary>
		DOWNLOAD_OUTLINE=4,
	}
}
