using System;
using System.Runtime.InteropServices;

namespace Win32.HumanInterfaceDevices
{
	/// <summary>
	/// Contains information about the state of the mouse.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	[CLSCompliant(false)]
	public struct RAWMOUSE
	{
		/// <summary>
		/// The mouse state.
		/// </summary>
		[FieldOffset(0)]
		public MOUSE usFlags;

		/// <summary>
		/// Reserved.
		/// </summary>
		[FieldOffset(4)]
		public uint ulButtons;

		/// <summary>
		/// The transition state of the mouse buttons.
		/// </summary>
		[FieldOffset(4)]
		public RI_MOUSE usButtonFlags;

		/// <summary>
		/// If <see cref="usButtonFlags"/> is <see cref="RI_MOUSE.WHEEL">RI_MOUSE_WHEEL</see>,
		/// this member is a signed value that specifies the wheel delta.
		/// </summary>
		[FieldOffset(6)]
		public ushort usButtonData;

		/// <summary>
		/// The raw state of the mouse buttons.
		/// </summary>
		[FieldOffset(8)]
		public uint ulRawButtons;
		
		/// <summary>
		/// The motion in the X direction. This is signed relative motion or absolute motion,
		/// depending on the value of <see cref="usFlags"/>.
		/// </summary>
		[FieldOffset(12)]
		public int lLastX;
		
		/// <summary>
		/// The motion in the Y direction. This is signed relative motion or absolute motion,
		/// depending on the value of <see cref="usFlags"/>.
		/// </summary>
		[FieldOffset(16)]
		public int lLastY;

		/// <summary>
		/// The device-specific additional information for the event.
		/// </summary>
		[FieldOffset(20)]
		public uint ulExtraInformation;
	}
}
