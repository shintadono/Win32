using System;
using HDC=System.IntPtr;
using HGLRC=System.IntPtr;

namespace Win32.WGL
{
	/// <summary>
	/// Bitmask for the values of <see cref="wglContextAttributeARB.CONTEXT_FLAGS_ARB"/> at <see cref="wgl.CreateContextAttribsARB(HDC, HGLRC, int[])">wgl.CreateContextAttribsARB</see>.
	/// </summary>
	[Flags]
	public enum wglContextFlagsARB : int
	{
		/// <summary>
		/// Requests a debug context.
		/// </summary>
		CONTEXT_DEBUG_BIT_ARB=0x0001,

		/// <summary>
		/// Requests a forward compatible context.
		/// </summary>
		CONTEXT_FORWARD_COMPATIBLE_BIT_ARB=0x0002,

		/// <summary>
		/// Requests a context supporting robust buffer access.
		/// </summary>
		CONTEXT_ROBUST_ACCESS_BIT_ARB=0x00000004,

		/// <summary>
		/// Requests isolation support for graphics resets.
		/// </summary>
		CONTEXT_RESET_ISOLATION_BIT_ARB=0x00000008,
	}
}
