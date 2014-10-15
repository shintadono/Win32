using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// Class for miscellaneous kernel32.dll functions.
	/// </summary>
	public static class WinKernel
	{
		const string DLLName="Kernel32.dll";

		/// <summary>
		/// Retrieves the calling thread's last-error code value. The last-error code is maintained on a per-thread basis. Multiple threads do not overwrite each other's last-error code.
		/// </summary>
		/// <remarks>This is for convenience only, you should use <see cref="Marshal.GetLastWin32Error"/>.</remarks>
		/// <returns>The last-error code.</returns>
		[DllImport(DLLName)]
		public static extern uint GetLastError();
	}
}
