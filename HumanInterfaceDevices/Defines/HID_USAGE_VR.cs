using System;

namespace Win32.HumanInterfaceDevices
{
	/// <summary>
	/// Defines the usage of "Human Interface Devices" on Usage Page 3 (VR Controls)
	/// </summary>
	[CLSCompliant(false)]
	public static class HID_USAGE_VR
	{
		/// <summary>
		/// Unidentified
		/// </summary>
		public const ushort UNIDENTIFIED=0x00;

		/// <summary>
		/// Belt
		/// </summary>
		public const ushort BELT=0x01;

		/// <summary>
		/// Body Suit
		/// </summary>
		public const ushort BODY_SUIT=0x02;

		/// <summary>
		/// Flexor
		/// </summary>
		public const ushort FLEXOR=0x03;

		/// <summary>
		/// Glove
		/// </summary>
		public const ushort GLOVE=0x04;

		/// <summary>
		/// Head Tracker
		/// </summary>
		public const ushort HEAD_TRACKER=0x05;

		/// <summary>
		/// Head Mounted Display
		/// </summary>
		public const ushort HEAD_MOUNTED_DISPLAY=0x06;

		/// <summary>
		/// Hand Tracker
		/// </summary>
		public const ushort HAND_TRACKER=0x07;

		/// <summary>
		/// Oculometer
		/// </summary>
		public const ushort OCULOMETER=0x08;

		/// <summary>
		/// Vest
		/// </summary>
		public const ushort VEST=0x09;

		/// <summary>
		/// Animatronic Device
		/// </summary>
		public const ushort ANIMATRONIC_DEVICE=0x0a;

		//public const ushort reserved=0x0b;
		//...
		//public const ushort reserved=0x1f;

		/// <summary>
		/// Stereo Enable
		/// </summary>
		public const ushort STEREO_ENABLE=0x20;

		/// <summary>
		/// Display Enable
		/// </summary>
		public const ushort DISPLAY_ENABLE=0x21;

		//public const ushort reserved=0x22;
		//...
		//public const ushort reserved=0xffff;
	}
}
