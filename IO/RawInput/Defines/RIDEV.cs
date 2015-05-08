using System;

namespace Win32.IO.RawInput
{
	/// <summary>
	/// Mode flag that specifies how to interpret the information provided by
	/// <see cref="RAWINPUTDEVICE.usUsagePage"/> and <see cref="RAWINPUTDEVICE.usUsage"/>.
	/// </summary>
	[CLSCompliant(false)]
	[Flags]
	public enum RIDEV : uint
	{
		/// <summary>
		/// Default.
		/// </summary>
		NONE=0,

		/// <summary>
		/// If set, this removes the top level collection from the inclusion list. This tells the operating
		/// system to stop reading from a device which matches the top level collection.
		/// </summary>
		REMOVE=0x00000001,

		/// <summary>
		/// If set, this specifies the top level collections to exclude when reading a complete usage page.
		/// This flag only affects a TLC (top level collection) whose usage page is already specified with
		/// <see cref="RIDEV.PAGEONLY">RIDEV_PAGEONLY</see>.
		/// </summary>
		EXCLUDE=0x00000010,

		/// <summary>
		/// If set, this specifies all devices whose top level collection is from the specified
		/// <see cref="RAWINPUTDEVICE.usUsagePage"/>. Note that <see cref="RAWINPUTDEVICE.usUsage"/>
		/// must be zero. To exclude a particular top level collection, use
		/// <see cref="RIDEV.EXCLUDE">RIDEV_EXCLUDE</see>.
		/// </summary>
		PAGEONLY=0x00000020,

		/// <summary>
		/// If set, this prevents any devices specified by <see cref="RAWINPUTDEVICE.usUsagePage"/>
		/// or <see cref="RAWINPUTDEVICE.usUsage"/> from generating legacy messages. This is only
		/// for the mouse and keyboard. See <see cref="RAWINPUTDEVICE">Remarks</see>.
		/// </summary>
		NOLEGACY=0x00000030,

		/// <summary>
		/// If set, this enables the caller to receive the input even when the caller is not in the
		/// foreground. Note that <see cref="RAWINPUTDEVICE.hwndTarget"/> must be specified.
		/// </summary>
		INPUTSINK=0x00000100,

		/// <summary>
		/// If set, the mouse button click does not activate the other window.
		/// </summary>
		CAPTUREMOUSE=0x00000200,

		/// <summary>
		/// If set, the application-defined keyboard device hotkeys are not handled. However, the system
		/// hotkeys; for example, [ALT]+[TAB] and [CTRL]+[ALT]+[DEL], are still handled. By default, all
		/// keyboard hotkeys are handled. <see cref="RIDEV.NOHOTKEYS">RIDEV_NOHOTKEYS</see> can be specified
		/// even if <see cref="RIDEV.NOLEGACY">RIDEV_NOLEGACY</see> is not specified and
		/// <see cref="RAWINPUTDEVICE.hwndTarget"/> is <b>null</b> (IntPtr.Zero).
		/// </summary>
		NOHOTKEYS=0x00000200,

		/// <summary>
		/// If set, the application command keys are handled. <see cref="RIDEV.APPKEYS">RIDEV_APPKEYS</see>
		/// can be specified only if <see cref="RIDEV.NOLEGACY">RIDEV_NOLEGACY</see> is specified for a
		/// keyboard device.
		/// </summary>
		APPKEYS=0x00000400,

		/// <summary>
		/// If set, this enables the caller to receive input in the background only if the foreground
		/// application does not process it. In other words, if the foreground application is not registered
		/// for raw input, then the background application that is registered will receive the input.
		/// </summary>
		/// <remarks><b>Windows XP:</b> This flag is not supported until Windows Vista</remarks>
		EXINPUTSINK=0x00001000,

		/// <summary>
		/// If set, this enables the caller to receive <see cref="WM.INPUT_DEVICE_CHANGE">WM_INPUT_DEVICE_CHANGE</see>
		/// notifications for device arrival and device removal. This works only when <see cref="INPUTSINK"/>
		/// is also set (and of course <see cref="RAWINPUTDEVICE.hwndTarget"/> must be specified).
		/// </summary>
		/// <remarks><b>Windows XP:</b> This flag is not supported until Windows Vista</remarks>
		DEVNOTIFY=0x00002000,

		/// <summary>
		/// Usage: mode&amp;RIDEV.EXMODEMASK.
		/// </summary>
		EXMODEMASK=0x000000F0,
	}
}
