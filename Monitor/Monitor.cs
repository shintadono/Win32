using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using HDC=System.IntPtr;
using HMONITOR=System.IntPtr;

namespace Win32
{
	/// <summary>
	/// Class for managing monitor devices.
	/// </summary>
	[SuppressUnmanagedCodeSecurity()]
	public class Monitor
	{
		/// <summary>
		/// Handle to the display monitor.
		/// </summary>
		public readonly HMONITOR hMonitor;

		/// <summary>
		/// Handle to device context.
		/// </summary>
		public readonly HDC hdcMonitor;

		/// <summary>
		/// Rectangle with the intersection of the clipping area of the device context and the display monitor rectangle.
		/// </summary>
		public readonly Rect lprcMonitor;

		private Monitor() { }

		/// <summary>
		/// Initializes the class.
		/// </summary>
		/// <param name="hMonitor">Handle to the display monitor.</param>
		/// <param name="hdcMonitor">Handle to device context.</param>
		/// <param name="lprcMonitor">Rectangle with the intersection of the clipping area of the device context and the display monitor rectangle.</param>
		public Monitor(HMONITOR hMonitor, HDC hdcMonitor, Rect lprcMonitor)
		{
			this.hMonitor=hMonitor;
			this.hdcMonitor=hdcMonitor;
			this.lprcMonitor=lprcMonitor;
		}

		#region Static Stuff
		const string DLLName="User32.dll";
		const string GetMonitorInfoW="GetMonitorInfoW";

		delegate bool MONITORENUMPROC(HMONITOR hMonitor, HDC hdcMonitor, ref Rect lprcMonitor, IntPtr dwData);

		[DllImport(DLLName)]
		static extern bool EnumDisplayMonitors(HDC hdc, [In] ref Rect lprcClip, MONITORENUMPROC lpfnEnum, IntPtr dwData);

		[DllImport(DLLName)]
		static extern bool EnumDisplayMonitors(HDC hdc, IntPtr lpNULL, MONITORENUMPROC lpfnEnum, IntPtr dwData);

		/// <summary>
		/// Retrieves information about a display monitor.
		/// </summary>
		/// <param name="hMonitor">The handle to the display monitor of interest.</param>
		/// <param name="lpmi">Structure of type <see cref="MonitorInfo"/> to receive the requested informations.
		/// <see cref="MonitorInfo.cbSize"/> must be initialized with the size of <see cref="MonitorInfo"/>.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName, EntryPoint=GetMonitorInfoW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public static extern bool GetMonitorInfo(HMONITOR hMonitor, ref MonitorInfo lpmi);

		/// <summary>
		/// Retrieves information about a display monitor.
		/// </summary>
		/// <param name="hMonitor">The handle to the display monitor of interest.</param>
		/// <param name="lpmiex">Structure of type <see cref="MonitorInfoEx"/> to receive the requested informations. <see cref="MonitorInfoEx.cbSize"/> must be initialized with the size of <see cref="MonitorInfoEx"/>.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName, EntryPoint=GetMonitorInfoW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public static extern bool GetMonitorInfo(HMONITOR hMonitor, ref MonitorInfoEx lpmiex);

		static bool MonitorEnumProc(HMONITOR hMonitor, HDC hdcMonitor, ref Rect lprcMonitor, IntPtr dwData)
		{
			List<Monitor> monitors=(List<Monitor>)GCHandle.FromIntPtr(dwData).Target;
			monitors.Add(new Monitor(hMonitor, hdcMonitor, lprcMonitor));

			//MonitorInfo mi=new MonitorInfo();
			//mi.cbSize=(uint)Marshal.SizeOf(mi);
			//GetMonitorInfo(hMonitor, ref mi);

			return true;
		}

		/// <summary>
		/// Returns a list of all monitors (including invisible pseudo-monitors).
		/// </summary>
		/// <returns>A list of all monitors.</returns>
		public static List<Monitor> GetDisplayMonitors() { return GetDisplayMonitors(HDC.Zero); }

		/// <summary>
		/// Returns a list of all monitors (including invisible pseudo-monitors).
		/// </summary>
		/// <param name="hdc">The handle to a display device context that defines the visible region of interest.</param>
		/// <returns>A list of all monitors.</returns>
		public static List<Monitor> GetDisplayMonitors(HDC hdc)
		{
			List<Monitor> monitors=new List<Monitor>();

			GCHandle data=GCHandle.Alloc(monitors);
			try
			{
				EnumDisplayMonitors(hdc, IntPtr.Zero, MonitorEnumProc, GCHandle.ToIntPtr(data));
			}
			finally
			{
				data.Free();
			}

			return monitors;
		}

		/// <summary>
		/// Returns a list of all monitors (including invisible pseudo-monitors).
		/// </summary>
		/// <param name="rect">The region of interest as rectangle in virtual-screen coordinates.</param>
		/// <returns>A list of all monitors.</returns>
		public static List<Monitor> GetDisplayMonitors(Rect rect) { return GetDisplayMonitors(HDC.Zero, rect); }

		/// <summary>
		/// Returns a list of all monitors (including invisible pseudo-monitors).
		/// </summary>
		/// <param name="hdc">The handle to a display device context that defines the visible region of interest.</param>
		/// <param name="rect">The region of interest as rectangle in virtual-screen coordinates if <paramref name="hdc"/> is <b>null</b>, otherwise in coordinates relative the the device context.</param>
		/// <returns>A list of all monitors.</returns>
		public static List<Monitor> GetDisplayMonitors(HDC hdc, Rect rect)
		{
			List<Monitor> monitors=new List<Monitor>();

			GCHandle data=GCHandle.Alloc(monitors);
			try
			{
				EnumDisplayMonitors(hdc, ref rect, MonitorEnumProc, GCHandle.ToIntPtr(data));
			}
			finally
			{
				data.Free();
			}

			return monitors;
		}
		#endregion
	}
}
