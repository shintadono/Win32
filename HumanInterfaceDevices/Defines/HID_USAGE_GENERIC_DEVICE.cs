using System;

namespace Win32.HumanInterfaceDevices
{
	/// <summary>
	/// Defines the usage of "Human Interface Devices" on Usage Page 6 (Generic Device Controls)
	/// </summary>
	[CLSCompliant(false)]
	public static class HID_USAGE_GENERIC_DEVICE
	{
		/// <summary>
		/// Unidentified
		/// </summary>
		public const ushort UNIDENTIFIED=0x00;

		//public const ushort reserved=0x01;
		//...
		//public const ushort reserved=0x1f;

		/// <summary>
		/// Battery Strength
		/// </summary>
		public const ushort BATTERY_STRENGTH=0x20;

		/// <summary>
		/// Wireless Channel
		/// </summary>
		public const ushort WIRELESS_CHANNEL=0x21;

		/// <summary>
		/// Wireless ID
		/// </summary>
		public const ushort WIRELESS_ID=0x22;

		/// <summary>
		/// Discover Wireless Control
		/// </summary>
		public const ushort DISCOVER_WIRELESS_CONTROL=0x23;

		/// <summary>
		/// Security Code Character Entered
		/// </summary>
		public const ushort SECURITY_CODE_CHARACTER_ENTERED=0x24;

		/// <summary>
		/// Security Code Character Erased
		/// </summary>
		public const ushort SECURITY_CODE_CHARACTER_ERASED=0x25;

		/// <summary>
		/// Security Code Cleared
		/// </summary>
		public const ushort SECURITY_CODE_CLEARED=0x26;

		//public const ushort reserved=0x27;
		//...
		//public const ushort reserved=0xffff;
	}
}
