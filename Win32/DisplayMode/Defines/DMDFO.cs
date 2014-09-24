namespace Win32
{
	/// <summary>
	/// For fixed-resolution display devices only, how the display presents a low-resolution mode on a higher-resolution display.
	/// </summary>
	public enum DMDFO : uint
	{
		/// <summary>
		/// The display's default setting.
		/// </summary>
		DEFAULT=0,

		/// <summary>
		/// The low-resolution image is stretched to fill the larger screen space.
		/// </summary>
		STRETCH=1,

		/// <summary>
		/// The low-resolution image is centered in the larger screen space.
		/// </summary>
		CENTER=2,
	}
}
