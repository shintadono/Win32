using System;
using System.Runtime.InteropServices;
using System.Security;
using HDC=System.IntPtr;

namespace Win32
{
	/// <summary>
	/// Class containing function of the GDI relevant for OpenGL initialization.
	/// </summary>
	[SuppressUnmanagedCodeSecurity()]
	public static class DeviceContext
	{
		const string DLLName="GDI32.dll";

		/// <summary>
		/// Attempts to match an appropriate pixel format supported by a device context to a given pixel format specification.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="ppfd">A <see cref="PixelFormatDescriptor"/> structure specifying the pixel format.
		/// <see cref="PixelFormatDescriptor.nSize"/> must be initialized with the size of <see cref="PixelFormatDescriptor"/>.</param>
		/// <returns>If successful the pixel format (greater zero), ohterwise 0 (zero) is returned.</returns>
		[DllImport(DLLName)]
		public static extern int ChoosePixelFormat(HDC hdc, ref PixelFormatDescriptor ppfd);

		/// <summary>
		/// Obtains information about the pixel format.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="iPixelFormat">The pixel format.</param>
		/// <param name="nBytes">The size of the structure pointed to by <paramref name="ppfd"/> (<see cref="PixelFormatDescriptor"/>).</param>
		/// <param name="ppfd">Returns the pixel format specification.</param>
		/// <returns>If the function succeeds, the return value is the maximum pixel format index of
		/// the device context, otherwise 0 (zero) is returned.</returns>
		[DllImport(DLLName)]
		public static extern int DescribePixelFormat(HDC hdc, int iPixelFormat, uint nBytes, out PixelFormatDescriptor ppfd);

		/// <summary>
		/// Obtains information about the pixel format.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="iPixelFormat">The pixel format.</param>
		/// <param name="nBytes">The size of the structure pointed to by <paramref name="ppfd"/> (<see cref="PixelFormatDescriptor"/>).</param>
		/// <param name="ppfd">Returns the pixel format specification. Set 0 (zero) if only the maximum pixel format index of the device context is to be returned.</param>
		/// <returns>If the function succeeds, the return value is the maximum pixel format index of
		/// the device context, otherwise 0 (zero) is returned.</returns>
		[DllImport(DLLName)]
		public static extern int DescribePixelFormat(HDC hdc, int iPixelFormat, uint nBytes, IntPtr ppfd);

		/// <summary>
		/// Sets the pixel format of a device context. This is possible only once!
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="iPixelFormat">The pixel format.</param>
		/// <param name="ppfd">>A <see cref="PixelFormatDescriptor"/> structure specifying the pixel format.
		/// <see cref="PixelFormatDescriptor.nSize"/> must be initialized with the size of <see cref="PixelFormatDescriptor"/>.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName)]
		public static extern bool SetPixelFormat(HDC hdc, int iPixelFormat, ref PixelFormatDescriptor ppfd);

		/// <summary>
		/// Returns the index of the pixel format currently used by a device context.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <returns>The pixel format.</returns>
		[DllImport(DLLName)]
		public static extern int GetPixelFormat(HDC hdc);

		/// <summary>
		/// Swaps the front and back buffers of a device context.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName)]
		public static extern bool SwapBuffers(HDC hdc);
	}
}
