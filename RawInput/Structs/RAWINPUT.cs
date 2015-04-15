using System;
using System.Runtime.InteropServices;

namespace Win32.RawInput
{
	/// <summary>
	/// Contains the raw input from a device.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	[CLSCompliant(false)]
	public struct RAWINPUT
	{
		#region Union of RAWMOUSE, RAWKEYBOARD and RAWHID.
		/// <summary>
		/// Union of <see cref="RAWMOUSE"/>, <see cref="RAWKEYBOARD"/> and <see cref="RAWHID"/>.
		/// </summary>
		[StructLayout(LayoutKind.Explicit)]
		[CLSCompliant(false)]
		public struct DATA
		{
			/// <summary>
			/// If the data comes from a mouse, this is the raw input data.
			/// </summary>
			[FieldOffset(0)]
			public RAWMOUSE mouse;

			/// <summary>
			/// If the data comes from a keyboard, this is the raw input data.
			/// </summary>
			[FieldOffset(0)]
			public RAWKEYBOARD keyboard;

			/// <summary>
			/// If the data comes from an HID, this is the raw input data.
			/// </summary>
			[FieldOffset(0)]
			public RAWHID hid;
		}
		#endregion

		/// <summary>
		/// The raw input data header.
		/// </summary>
		public RAWINPUTHEADER header;

		/// <summary>
		/// The raw input data.
		/// </summary>
		public DATA data;
	}
}
