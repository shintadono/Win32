namespace Win32
{
	/// <summary>
	/// Specifies the current playback mode.
	/// </summary>
	public enum VP_MODE : uint
	{
		/// <summary>
		/// Describes a set of display settings that are optimal for display on a Windows Embedded CE-based device, with the flicker filter on and any overscan display off.
		/// </summary>
		WIN_GRAPHICS=0x0001,

		/// <summary>
		/// Describes a set of display settings for video playback, with the flicker filter off and the overscan display on.
		/// </summary>
		TV_PLAYBACK=0x0002,
	}
}
