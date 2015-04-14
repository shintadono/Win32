using System;
using System.Runtime.InteropServices;

namespace Win32.HumanInterfaceDevices
{
	/// <summary>
	/// Contains the raw input from a device.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[CLSCompliant(false)]
	public struct RAWINPUT32
	{
		/// <summary>
		/// The raw input data.
		/// </summary>
		[FieldOffset(0)]
		public RAWINPUTHEADER header;

		/// <summary>
		/// If the data comes from a mouse, this is the raw input data.
		/// </summary>
		[FieldOffset(16)]
		public RAWMOUSE mouse;

		/// <summary>
		/// If the data comes from a keyboard, this is the raw input data.
		/// </summary>
		[FieldOffset(16)]
		public RAWKEYBOARD keyboard;

		/// <summary>
		/// If the data comes from an HID, this is the raw input data.
		/// </summary>
		[FieldOffset(16)]
		public RAWHID hid;
	}

	/// <summary>
	/// Contains the raw input from a device.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[CLSCompliant(false)]
	public struct RAWINPUT64
	{
		/// <summary>
		/// The raw input data.
		/// </summary>
		[FieldOffset(0)]
		public RAWINPUTHEADER header;

		/// <summary>
		/// If the data comes from a mouse, this is the raw input data.
		/// </summary>
		[FieldOffset(24)]
		public RAWMOUSE mouse;

		/// <summary>
		/// If the data comes from a keyboard, this is the raw input data.
		/// </summary>
		[FieldOffset(24)]
		public RAWKEYBOARD keyboard;

		/// <summary>
		/// If the data comes from an HID, this is the raw input data.
		/// </summary>
		[FieldOffset(24)]
		public RAWHID hid;
	}
}
