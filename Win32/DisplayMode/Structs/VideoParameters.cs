using System;

namespace Win32
{
	/// <summary>
	/// This structure contains information for a video connection.
	/// </summary>
	public struct VideoParameters
	{
		/// <summary>
		/// Globally unique identifier (GUID) for this structure, {02C62061-1097-11d1-920F-00A024DF156E}.
		/// Display drivers should verify the GUID before processing the structure.
		/// </summary>
		public Guid guid;

		/// <summary>
		/// Reserved; must be zero.
		/// </summary>
		public uint dwOffset;

		/// <summary>
		/// Specifies whether to retrieve or set the values that the other members of this structure specify.
		/// </summary>
		public VP_COMMAND dwCommand;

		/// <summary>
		/// Indicates the members that contain valid data.
		/// </summary>
		public VP_FLAGS dwFlags;

		/// <summary>
		/// Specifies the current playback mode.
		/// </summary>
		public VP_MODE dwMode;

		/// <summary>
		/// Specifies the television standard.
		/// </summary>
		public VP_TV_STANDARD dwTVStandard;

		/// <summary>
		/// Specifies the modes that are available.
		/// </summary>
		public uint dwAvailableModes;

		/// <summary>
		/// Specifies the TV standards that are available.
		/// </summary>
		public uint dwAvailableTVStandard;

		/// <summary>
		/// Specifies the flicker reduction provided by the hardware.
		/// </summary>
		public uint dwFlickerFilter;

		/// <summary>
		/// Specifies the amount of overscan in the horizontal direction.
		/// </summary>
		public uint dwOverScanX;

		/// <summary>
		/// Specifies the amount of overscan in the vertical direction.
		/// </summary>
		public uint dwOverScanY;

		/// <summary>
		/// Specifies the maximum horizontal resolution, in pixels, that is supported when the video is not scaled.
		/// </summary>
		public uint dwMaxUnscaledX;

		/// <summary>
		/// Specifies the maximum vertical resolution, in pixels, that is supported when the video is not scaled.
		/// </summary>
		public uint dwMaxUnscaledY;

		/// <summary>
		/// pecifies the horizontal adjustment to the center of the image, in scan lines.
		/// </summary>
		public uint dwPositionX;

		/// <summary>
		/// pecifies the vertical adjustment to the center of the image, in scan lines.
		/// </summary>
		public uint dwPositionY;

		/// <summary>
		/// Specifies the direct current (DC) offset of the video signal to increase brightness on the television.
		/// </summary>
		public uint dwBrightness;

		/// <summary>
		/// Specifies to the gain of the video signal to increase the intensity of whiteness on the television.
		/// </summary>
		public uint dwContrast;

		/// <summary>
		/// Specifies the copy protection type.
		/// </summary>
		public VP_CP_TYPE dwCPType;

		/// <summary>
		/// Specifies the copy protection command.
		/// </summary>
		public VP_CP_CMD dwCPCommand;

		/// <summary>
		/// Specifies TV standards for which copy protection types are available.
		/// </summary>
		public uint dwCPStandard;

		/// <summary>
		/// Specifies the copy protection key returned if <see cref="dwCPCommand"/> is set to <see cref="VP_CP_CMD.ACTIVATE"/>.
		/// </summary>
		public uint dwCPKey;

		/// <summary>
		/// Specifies the digital video disc (DVD) analog protection system (APS) trigger bit value.
		/// </summary>
		public uint bCP_APSTriggerBits;

		/// <summary>
		/// Specifies the OEM-specific copy protection data.
		/// </summary>
		public unsafe fixed byte bOEMCopyProtection[256];
	}
}
