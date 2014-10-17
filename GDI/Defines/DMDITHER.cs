namespace Win32
{
	/// <summary>
	/// Specifies how dithering is to be done.
	/// </summary>
	public enum DMDITHER : uint
	{
		/// <summary>
		/// No dithering
		/// </summary>
		NONE=1,

		/// <summary>
		/// Dither with a coarse brush
		/// </summary>
		COARSE=2,

		/// <summary>
		/// Dither with a fine brush
		/// </summary>
		FINE=3,

		/// <summary>
		/// LineArt dithering
		/// </summary>
		LINEART=4,

		/// <summary>
		/// LineArt dithering
		/// </summary>
		ERRORDIFFUSION=5,

		/// <summary>
		/// LineArt dithering
		/// </summary>
		RESERVED6=6,

		/// <summary>
		/// LineArt dithering
		/// </summary>
		RESERVED7=7,

		/// <summary>
		/// LineArt dithering
		/// </summary>
		RESERVED8=8,

		/// <summary>
		/// LineArt dithering
		/// </summary>
		RESERVED9=9,

		/// <summary>
		/// Device does grayscaling
		/// </summary>
		GRAYSCALE=10,

		/// <summary>
		/// Start of the user-defined dithers.
		/// </summary>
		USER=256,
	}
}
