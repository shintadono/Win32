using System;

namespace Win32.HumanInterfaceDevices
{
	/// <summary>
	/// Defines the usage pages for "Human Interface Devices".
	/// </summary>
	[CLSCompliant(false)]
	public static class HID_USAGE_PAGE
	{
		/// <summary>
		/// Undefined
		/// </summary>
		public const ushort UNDEFINED=0x0000;

		/// <summary>
		/// Generic Desktop Controls
		/// </summary>
		public const ushort GENERIC_DESKTOP=0x0001;

		/// <summary>
		/// Simulation Controls
		/// </summary>
		public const ushort SIMULATION=0x0002;

		/// <summary>
		/// VR Controls
		/// </summary>
		public const ushort VR=0x0003;

		/// <summary>
		/// Sport Controls
		/// </summary>
		public const ushort SPORT=0x0004;

		/// <summary>
		/// Game Controls
		/// </summary>
		public const ushort GAME=0x0005;

		/// <summary>
		/// Generic Device Controls
		/// </summary>
		public const ushort GENERIC_DEVICE=0x0006;

		/// <summary>
		/// Keyboard/Keypad
		/// </summary>
		public const ushort KEYBOARD=0x0007;

		/// <summary>
		/// LEDs
		/// </summary>
		public const ushort LEDS=0x0008;

		/// <summary>
		/// Button
		/// </summary>
		public const ushort BUTTON=0x0009;

		/// <summary>
		/// Ordinal
		/// </summary>
		public const ushort ORDINAL=0x000a;

		/// <summary>
		/// Telephony
		/// </summary>
		public const ushort TELEPHONY=0x000b;

		/// <summary>
		/// Consumer
		/// </summary>
		public const ushort CONSUMER=0x000c;

		/// <summary>
		/// Digitizer
		/// </summary>
		public const ushort DIGITIZER=0x000d;

		//public const ushort resevered=0x000e;

		/// <summary>
		/// USB Physical Interface Devices
		/// </summary>
		public const ushort PID=0x000f;

		/// <summary>
		/// Unicode
		/// </summary>
		public const ushort UNICODE=0x0010;

		//public const ushort resevered=0x0011;
		//public const ushort resevered=0x0012;
		//public const ushort resevered=0x0013;

		/// <summary>
		/// Alphanumeric Display
		/// </summary>
		public const ushort ALPHANUMERIC=0x0014;

		//public const ushort resevered=0x0015;
		//...
		//public const ushort resevered=0x003f;

		/// <summary>
		/// Medical Instruments
		/// </summary>
		public const ushort MEDICAL=0x0040;

		//public const ushort resevered=0x0041;
		//...
		//public const ushort resevered=0x007f;

		/// <summary>
		/// Monitor
		/// </summary>
		public const ushort MONITOR=0x0080;

		/// <summary>
		/// Monitor Enumerated Values
		/// </summary>
		public const ushort MONITOR_ENUMERATED_VALUES=0x0081;

		/// <summary>
		/// VESA Virtual Controls
		/// </summary>
		public const ushort VESA_VIRTUAL=0x0082;

		/// <summary>
		/// VESA Command
		/// </summary>
		public const ushort VESA_COMMAND=0x0083;

		/// <summary>
		/// Power Device
		/// </summary>
		public const ushort POWER=0x0084;

		/// <summary>
		/// Battery System
		/// </summary>
		public const ushort BATTERY=0x0085;

		/// <summary>
		/// Power Page 3
		/// </summary>
		public const ushort POWER_PAGE_3=0x0086;

		/// <summary>
		/// Power Page 4
		/// </summary>
		public const ushort POWER_PAGE_4=0x0087;

		//public const ushort resevered=0x0088;
		//...
		//public const ushort resevered=0x008b;

		/// <summary>
		/// Bar Code Scanner
		/// </summary>
		public const ushort BAR_CODE_SCANNER=0x008c;

		/// <summary>
		/// Scale Device
		/// </summary>
		public const ushort SCALE=0x008d;

		/// <summary>
		/// Magnetic Stripe Reading (MSR) Devices
		/// </summary>
		public const ushort MSR=0x008e;

		/// <summary>
		/// Reserved Point of Sale
		/// </summary>
		public const ushort POINT_OF_SALE=0x008f;

		/// <summary>
		/// Camera Control
		/// </summary>
		public const ushort CAMERA=0x0090;

		/// <summary>
		/// Arcade Device
		/// </summary>
		public const ushort ARCADE=0x0091;

		//public const ushort resevered=0x0092;
		//...
		//public const ushort resevered=0xfeff;

		/// <summary>
		/// First allowed Vendor-defined usage page
		/// </summary>
		public const ushort VENDOR_DEFINED_FIRST=0xff00;

		/// <summary>
		/// Last allowed Vendor-defined usage page
		/// </summary>
		public const ushort VENDOR_DEFINED_LAST=0xffff;
	}
}
