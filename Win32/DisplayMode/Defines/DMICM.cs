namespace Win32
{
	/// <summary>
	/// Specifies which color matching method, or intent, should be used by default.
	/// </summary>
	public enum DMICM : uint
	{
		/// <summary>
		/// Color matching should optimize for color saturation. This value is the most appropriate choice for business graphs when dithering is not desired.
		/// </summary>
		SATURATE=1,

		/// <summary>
		/// Color matching should optimize for color contrast. This value is the most appropriate choice for scanned or photographic images when dithering is desired.
		/// </summary>
		CONTRAST=2,

		/// <summary>
		/// Color matching should optimize to match the exact color requested. This value is most appropriate for use with business logos or other images when an exact color match is desired.
		/// </summary>
		COLORIMETRIC=3,

		/// <summary>
		/// Color matching should optimize to match the exact color requested without white point mapping. This value is most appropriate for use with proofing.
		/// </summary>
		ABS_COLORIMETRIC=4,

		/// <summary>
		/// Start of the user-defined color matching methods.
		/// </summary>
		USER=256,
	}
}
