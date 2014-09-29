namespace Win32
{
	/// <summary>
	/// Specifies special mode numbers of <see cref="O:Win32.DisplayMode.EnumDisplaySettings">DisplayMode.EnumDisplaySettings</see> and
	/// <see cref="O:Win32.DisplayMode.EnumDisplaySettingsEx">DisplayMode.EnumDisplaySettingsEx</see>.
	/// </summary>
	public enum DisplaySettingsMode : uint
	{
		/// <summary>
		/// Retrieve the current settings for the display device.
		/// </summary>
		ENUM_CURRENT_SETTINGS=0xFFFFFFFF,

		/// <summary>
		/// Retrieve the settings for the display device that are currently stored in the registry.
		/// </summary>
		ENUM_REGISTRY_SETTINGS=0xFFFFFFFE
	}
}
