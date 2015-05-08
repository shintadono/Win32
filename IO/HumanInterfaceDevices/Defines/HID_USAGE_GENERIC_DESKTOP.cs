using System;

namespace Win32.IO.HumanInterfaceDevices
{
	/// <summary>
	/// Defines the usage of "Human Interface Devices" on Usage Page 1 (Generic Desktop Controls)
	/// </summary>
	[CLSCompliant(false)]
	public static class HID_USAGE_GENERIC_DESKTOP
	{
		/// <summary>
		/// Undefined
		/// </summary>
		public const ushort UNDEFINED=0x00;

		/// <summary>
		/// Pointer
		/// </summary>
		public const ushort POINTER=0x01;

		/// <summary>
		/// Mouse
		/// </summary>
		public const ushort MOUSE=0x02;

		//public const ushort reserved=0x03;

		/// <summary>
		/// Joystick
		/// </summary>
		public const ushort JOYSTICK=0x04;

		/// <summary>
		/// Game Pad
		/// </summary>
		public const ushort GAMEPAD=0x05;

		/// <summary>
		/// Keyboard
		/// </summary>
		public const ushort KEYBOARD=0x06;

		/// <summary>
		/// Keypad
		/// </summary>
		public const ushort KEYPAD=0x07;

		/// <summary>
		/// Multi-axis Controller
		/// </summary>
		public const ushort MULTIAXIS_CONTROLLER=0x08;

		/// <summary>
		/// Tablet PC System Controls
		/// </summary>
		public const ushort TABLET_PC_SYSTEM_CONTROLS=0x09;

		//public const ushort reserved=0x0a;
		//...
		//public const ushort reserved=0x2f;

		/// <summary>
		/// X
		/// </summary>
		public const ushort X=0x30;

		/// <summary>
		/// Y
		/// </summary>
		public const ushort Y=0x31;

		/// <summary>
		/// Z
		/// </summary>
		public const ushort Z=0x32;

		/// <summary>
		/// Rx
		/// </summary>
		public const ushort RX=0x33;

		/// <summary>
		/// Ry
		/// </summary>
		public const ushort RY=0x34;

		/// <summary>
		/// Rz
		/// </summary>
		public const ushort Rz=0x35;

		/// <summary>
		/// Slider
		/// </summary>
		public const ushort SLIDER=0x36;

		/// <summary>
		/// Dial
		/// </summary>
		public const ushort DIAL=0x37;

		/// <summary>
		/// Wheel
		/// </summary>
		public const ushort WHEEL=0x38;

		/// <summary>
		/// Hat switch
		/// </summary>
		public const ushort HAT_SWITCH=0x39;

		/// <summary>
		/// Counted Buffer
		/// </summary>
		public const ushort COUNTED_BUFFER=0x3a;

		/// <summary>
		/// Byte Count
		/// </summary>
		public const ushort BYTE_COUNT=0x3b;

		/// <summary>
		/// Motion Wakeup
		/// </summary>
		public const ushort MOTION_WAKEUP=0x3c;

		/// <summary>
		/// Strart
		/// </summary>
		public const ushort START=0x3d;

		/// <summary>
		/// Select
		/// </summary>
		public const ushort SELECT=0x3e;

		//public const ushort reserved=0x3f;

		/// <summary>
		/// Vx
		/// </summary>
		public const ushort VX=0x40;

		/// <summary>
		/// Vy
		/// </summary>
		public const ushort VY=0x41;

		/// <summary>
		/// Vz
		/// </summary>
		public const ushort VZ=0x42;

		/// <summary>
		/// Vbrx
		/// </summary>
		public const ushort VBRX=0x43;

		/// <summary>
		/// Vbry
		/// </summary>
		public const ushort VBRY=0x44;

		/// <summary>
		/// Vbrz
		/// </summary>
		public const ushort VBRZ=0x45;

		/// <summary>
		/// Vno
		/// </summary>
		public const ushort VNO=0x46;

		/// <summary>
		/// Feature Notification
		/// </summary>
		public const ushort FEATURE_NOTIFICATION=0x47;

		/// <summary>
		/// Resolution Multiplier
		/// </summary>
		public const ushort RESOLUTION_MULTIPLIER=0x48;

		//public const ushort reserved=0x49;
		//...
		//public const ushort reserved=0x7f;

		/// <summary>
		/// System Control
		/// </summary>
		public const ushort SYSTEM_CONTROL=0x80;

		/// <summary>
		/// System Power Down
		/// </summary>
		public const ushort SYSTEM_POWER_DOWN=0x81;

		/// <summary>
		/// System Sleep
		/// </summary>
		public const ushort SYSTEM_SLEEP=0x82;

		/// <summary>
		/// System Wake Up
		/// </summary>
		public const ushort SYSTEM_WAKE_UP=0x83;

		/// <summary>
		/// System Context Menu
		/// </summary>
		public const ushort SYSTEM_CONTEXT_MENU=0x84;

		/// <summary>
		/// System Main Menu
		/// </summary>
		public const ushort SYSTEM_MAIN_MENU=0x85;

		/// <summary>
		/// System App Menu
		/// </summary>
		public const ushort SYSTEM_APP_MENU=0x86;

		/// <summary>
		/// System Menu Help
		/// </summary>
		public const ushort SYSTEM_MENU_HELP=0x87;

		/// <summary>
		/// System Menu Exit
		/// </summary>
		public const ushort SYSTEM_MENU_EXIT=0x88;

		/// <summary>
		/// System Menu Select
		/// </summary>
		public const ushort SYSTEM_MENU_Select=0x89;

		/// <summary>
		/// System Menu Right
		/// </summary>
		public const ushort SYSTEM_MENU_RIGHT=0x8a;

		/// <summary>
		/// System Menu Left
		/// </summary>
		public const ushort SYSTEM_MENU_LEFT=0x8b;

		/// <summary>
		/// System Menu Up
		/// </summary>
		public const ushort SYSTEM_MENU_UP=0x8c;

		/// <summary>
		/// System Menu Down
		/// </summary>
		public const ushort SYSTEM_MENU_DOWN=0x8d;

		/// <summary>
		/// System Cold Restart
		/// </summary>
		public const ushort SYSTEM_COLD_RESTART=0x8e;

		/// <summary>
		/// System Warm Restart
		/// </summary>
		public const ushort SYSTEM_WARM_RESTART=0x8f;

		/// <summary>
		/// Direction Pad Up
		/// </summary>
		public const ushort DPAD_UP=0x90;

		/// <summary>
		/// Direction Pad Down
		/// </summary>
		public const ushort DPAD_DOWN=0x91;

		/// <summary>
		/// Direction Pad Right
		/// </summary>
		public const ushort DPAD_RIGHT=0x92;

		/// <summary>
		/// Direction Pad Left
		/// </summary>
		public const ushort DPAD_LEFT=0x93;

		//public const ushort reserved=0x94;
		//...
		//public const ushort reserved=0x9f;

		/// <summary>
		/// System Dock
		/// </summary>
		public const ushort SYSTEM_DOCK=0xa0;

		/// <summary>
		/// System Undock
		/// </summary>
		public const ushort SYSTEM_UNDOCK=0xa1;

		/// <summary>
		/// System Setup
		/// </summary>
		public const ushort SYSTEM_SETUP=0xa2;

		/// <summary>
		/// System Break
		/// </summary>
		public const ushort SYSTEM_BREAK=0xa3;

		/// <summary>
		/// System Debugger Break
		/// </summary>
		public const ushort SYSTEM_DEBUGGER_BREAK=0xa4;

		/// <summary>
		/// Application Break
		/// </summary>
		public const ushort APPLICATION_BREAK=0xa5;

		/// <summary>
		/// Application Debugger Break
		/// </summary>
		public const ushort APPLICATION_DEBUGGER_BREAK=0xa6;

		/// <summary>
		/// System Speaker Mute
		/// </summary>
		public const ushort SYSTEM_SPEAKER_MUTE=0xa7;

		/// <summary>
		/// System Hibernate
		/// </summary>
		public const ushort SYSTEM_HIBERNATE=0xa8;

		//public const ushort reserved=0xa9;
		//...
		//public const ushort reserved=0xaf;

		/// <summary>
		/// System Display Invert
		/// </summary>
		public const ushort SYSTEM_DISPLAY_INVERT=0xb0;

		/// <summary>
		/// System Display Internal
		/// </summary>
		public const ushort SYSTEM_DISPLAY_INTERNAL=0xb1;

		/// <summary>
		/// System Display External
		/// </summary>
		public const ushort SYSTEM_DISPLAY_EXTERNAL=0xb2;

		/// <summary>
		/// System Display Both
		/// </summary>
		public const ushort SYSTEM_DISPLAY_BOTH=0xb3;

		/// <summary>
		/// System Display Dual
		/// </summary>
		public const ushort SYSTEM_DISPLAY_DUAL=0xb4;

		/// <summary>
		/// System Display Toggle Int/Ext
		/// </summary>
		public const ushort SYSTEM_DISPLAY_TOGGLE=0xb5;

		/// <summary>
		/// System Display Swap Primary/Secondary
		/// </summary>
		public const ushort SYSTEM_DISPLAY_SWAP=0xb6;

		/// <summary>
		/// System Display LCD Autoscale
		/// </summary>
		public const ushort SYSTEM_DISPLAY_LCD_AUTOSCALE=0xb7;

		//public const ushort reserved=0xb8;
		//...
		//public const ushort reserved=0xffff;
	}
}
