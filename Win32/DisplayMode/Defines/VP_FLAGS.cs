using System;

namespace Win32
{
	/// <summary>
	/// Indicates the members that contain valid data.
	/// </summary>
	[Flags]
	public enum VP_FLAGS : uint
	{
		/// <summary>
		/// <see cref="VideoParameters.dwMode"/>.
		/// </summary>
		TV_MODE=0x0001,

		/// <summary>
		/// <see cref="VideoParameters.dwTVStandard"/>.
		/// </summary>
		TV_STANDARD=0x0002,

		/// <summary>
		/// <see cref="VideoParameters.dwFlickerFilter"/>.
		/// </summary>
		FLICKER=0x0004,

		/// <summary>
		/// <see cref="VideoParameters.dwOverScanX"/> and <see cref="VideoParameters.dwOverScanY"/>.
		/// </summary>
		OVERSCAN=0x0008,

		/// <summary>
		/// <see cref="VideoParameters.dwMaxUnscaledX"/> and <see cref="VideoParameters.dwMaxUnscaledY"/>. Do not use if <see cref="VideoParameters.dwCommand"/> is <see cref="VP_COMMAND.SET"/>.
		/// </summary>
		MAX_UNSCALED=0x0010,

		/// <summary>
		/// <see cref="VideoParameters.dwPositionX"/> and <see cref="VideoParameters.dwPositionY"/>.
		/// </summary>
		POSITION=0x0020,

		/// <summary>
		/// <see cref="VideoParameters.dwBrightness"/>.
		/// </summary>
		BRIGHTNESS=0x0040,

		/// <summary>
		/// <see cref="VideoParameters.dwContrast"/>.
		/// </summary>
		CONTRAST=0x0080,

		/// <summary>
		/// <see cref="VideoParameters.dwCPType"/>, <see cref="VideoParameters.dwCPCommand"/> and <see cref="VideoParameters.dwCPStandard"/>.
		/// </summary>
		COPYPROTECT=0x0100,
	}
}
