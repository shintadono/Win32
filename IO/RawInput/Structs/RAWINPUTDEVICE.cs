using System;
using System.Runtime.InteropServices;
using HWND=System.IntPtr;

namespace Win32.RawInput
{
	/// <summary>
	/// Defines information for the raw input devices.
	/// </summary>
	/// <remarks>
	/// <para>
	/// If <see cref="RIDEV.NOLEGACY">RIDEV_NOLEGACY</see> is set for a mouse or a keyboard, the system does not
	/// generate any legacy message for that device for the application. For example, if the mouse TLC is set with
	/// <see cref="RIDEV.NOLEGACY">RIDEV_NOLEGACY</see>, <see cref="WM.LBUTTONDOWN">WM_LBUTTONDOWN</see> and
	/// related legacy mouse messages are not generated. Likewise, if the keyboard TLC is set with
	/// <see cref="RIDEV.NOLEGACY">RIDEV_NOLEGACY</see>, <see cref="WM.KEYDOWN">WM_KEYDOWN</see> and related
	/// legacy keyboard messages are not generated.
	/// </para>
	/// <para>
	/// If <see cref="RIDEV.REMOVE">RIDEV_REMOVE</see> is set and the <see cref="hwndTarget"/> member is not set
	/// to <b>null</b> (IntPtr.Zero), then parameter validation will fail.
	/// </para>
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	[CLSCompliant(false)]
	public struct RAWINPUTDEVICE
	{
		/// <summary>
		/// Top level collection Usage page for the raw input device.
		/// </summary>
		public ushort usUsagePage;

		/// <summary>
		/// Top level collection Usage for the raw input device.
		/// </summary>
		public ushort usUsage;

		/// <summary>
		/// Mode flag that specifies how to interpret the information provided by
		/// <see cref="RAWINPUTDEVICE.usUsagePage">usagePage</see> and <see cref="RAWINPUTDEVICE.usUsage">usage</see>.
		/// It can be zero (the default). By default, the operating system sends raw input from devices with the
		/// specified top level collection (TLC) to the registered application as long as it has the window focus.
		/// </summary>
		public RIDEV dwFlags;

		/// <summary>
		/// A handle to the target window. If <b>null</b> (IntPtr.Zero) it follows the keyboard focus.
		/// </summary>
		public HWND hwndTarget;
	}
}
