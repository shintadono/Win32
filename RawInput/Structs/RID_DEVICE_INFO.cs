using System;
using System.Runtime.InteropServices;

namespace Win32.RawInput
{
	/// <summary>
	/// Defines the raw input data coming from any device.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[CLSCompliant(false)]
	public struct RID_DEVICE_INFO
	{
		/// <summary>
		/// The size, in bytes, of the <see cref="RID_DEVICE_INFO"/> structure.
		/// </summary>
		[FieldOffset(0)]
		public uint cbSize;

		/// <summary>
		/// The type of raw input data.
		/// </summary>
		[FieldOffset(4)]
		public RIM_TYPE dwType;

		/// <summary>
		/// If <see cref="dwType"/> is <see cref="RIM_TYPE.MOUSE"/>, this is the <see cref="RID_DEVICE_INFO_MOUSE"/>
		/// structure that defines the mouse.
		/// </summary>
		[FieldOffset(8)]
		public RID_DEVICE_INFO_MOUSE mouse;

		/// <summary>
		/// If <see cref="dwType"/> is <see cref="RIM_TYPE.KEYBOARD"/>, this is the <see cref="RID_DEVICE_INFO_KEYBOARD"/>
		/// structure that defines the keyboard.
		/// </summary>
		[FieldOffset(8)]
		public RID_DEVICE_INFO_KEYBOARD keyboard;

		/// <summary>
		/// If <see cref="dwType"/> is <see cref="RIM_TYPE.HID"/>, this is the <see cref="RID_DEVICE_INFO_HID"/>
		/// structure that defines the HID device.
		/// </summary>
		[FieldOffset(8)]
		public RID_DEVICE_INFO_HID hid;
	}
}
