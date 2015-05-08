using System;
using System.Runtime.InteropServices;

namespace Win32.IO.RawInput
{
	/// <summary>
	/// Describes the format of the raw input from a Human Interface Device (HID).
	/// </summary>
	/// <remarks>
	/// Each <see cref="WM.INPUT">WM_INPUT</see> can indicate several inputs, but all of the
	/// inputs come from the same HID. The size of the raw data array is
	/// <see cref="dwSizeHid"/>*<see cref="dwCount"/>.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	[CLSCompliant(false)]
	public struct RAWHID
	{
		/// <summary>
		/// The size, in bytes, of each HID input in the raw data array that follows this structure.
		/// </summary>
		public uint dwSizeHid;

		/// <summary>
		/// The number of HID inputs in the raw data array that follows this structure.
		/// </summary>
		public uint dwCount;

		/// <summary>
		/// Here the raw data array starts. But since we can't define structs with variable length,
		/// you'll have to access the raw data array directly.
		/// Here only the first byte is available.
		/// </summary>
		//public unsafe fixed byte rawData[1];
		public byte bRawData;

		/// <summary>
		/// Size of <see cref="RAWHID"/> in bytes.
		/// </summary>
		public static readonly uint SIZE=(uint)Marshal.SizeOf(typeof(RAWHID));
	}
}
