using System.Runtime.InteropServices;
using System.Security;

namespace Win32
{
	/// <summary>
	/// Class for miscellaneous kernel32.dll functions.
	/// </summary>
	[SuppressUnmanagedCodeSecurity]
	public static class WinKernel
	{
		const string DLLName="Kernel32.dll";

		/// <summary>
		/// Retrieves the calling thread's last-error code value. The last-error code is maintained on a per-thread basis. Multiple threads do not overwrite each other's last-error code.
		/// </summary>
		/// <remarks>This is for convenience only, you should use <see cref="Marshal.GetLastWin32Error"/> in conjunction with <see cref="DllImportAttribute.SetLastError"/> set <b>true</b>.</remarks>
		/// <returns>The last-error code.</returns>
		[DllImport(DLLName)]
		public static extern uint GetLastError();

		/// <summary>
		/// Sets the last-error code for the calling thread.
		/// </summary>
		[DllImport(DLLName)]
		public static extern void SetLastError(int error);

		/// <summary>
		/// Sets the last-error code for the calling thread.
		/// </summary>
		[DllImport(DLLName)]
		public static extern void SetLastError(uint error);

		/// <summary>
		/// Retrieves the current value of the performance counter, which is a high resolution (&lt;1µs) time stamp that can be used for time-interval measurements.
		/// </summary>
		/// <remarks>Use <see cref="QueryPerformanceFrequency"/> to query the frequency of the counter.</remarks>
		/// <param name="lpPerformanceCount">The variable that receives the current performance-counter value, in counts.</param>
		/// <returns><b>true</b> if successful; otherwise, <b>false</b>. Use <see cref="GetLastError"/> to get extended error information.</returns>
		[DllImport(DLLName)]
		public static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

		/// <summary>
		/// Retrieves the frequency of the performance counter. The frequency of the performance counter is fixed at system boot and is consistent across all processors. Therefore, the frequency need only be queried upon application initialization, and the result can be cached.
		/// </summary>
		/// <param name="lpFrequency">The variable that receives the current performance-counter frequency, in counts per second.</param>
		/// <returns><b>true</b> the installed hardware supports a high-resolution performance counter; otherwise, <b>false</b>. Use <see cref="GetLastError"/> to get extended error information.</returns>
		[DllImport(DLLName)]
		public static extern bool QueryPerformanceFrequency(out long lpFrequency);
	}
}
