using System;

namespace Win32
{
	/// <summary>
	/// Specifies flags for <see cref="DisplayMode.EnumDisplaySettingsEx(string, DisplaySettingsMode, ref DevMode, EDS)">DisplayMode.EnumDisplaySettingsEx</see>.
	/// </summary>
	[Flags]
	public enum EDS : uint
	{
		/// <summary>
		/// If set, the function will return all graphics modes reported by the adapter driver, regardless of monitor capabilities. Otherwise, it will only return modes that are compatible with current monitors.
		/// </summary>
		RAWMODE=0x00000002,

		/// <summary>
		/// If set, the function will return graphics modes in all orientations. Otherwise, it will only return modes that have the same orientation as the one currently set for the requested display.
		/// </summary>
		ROTATEDMODE=0x00000004,
	}
}
