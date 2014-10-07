using System;
using System.Runtime.InteropServices;
using System.Security;
using HDC=System.IntPtr;

namespace Win32
{
	/// <summary>
	/// Class for working with fonts.
	/// </summary>
	[SuppressUnmanagedCodeSecurity()]
	public static class Font
	{
		const string DLLName="GDI32.dll";
		const string GetGlyphOutlineW="GetGlyphOutlineW";

		/// <summary>
		/// The <b>GetGlyphOutline</b> function retrieves the outline or bitmap for a character in the TrueType font that is selected into the specified device context.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="uChar">The character for which data is to be returned.</param>
		/// <param name="uFormat">A <see cref="GGO"/> specifying the format of the data that the function retrieves.</param>
		/// <param name="lpgm">Returns a <see cref="GlyphMetrics"/> structure describing the placement of the glyph in the character cell.</param>
		/// <param name="cbBuffer">The size, in bytes, of the buffer (<paramref name="lpvBuffer"/>) where the function is to copy information about the outline character. If this value is zero, the function returns the required size of the buffer.</param>
		/// <param name="lpvBuffer">The buffer that receives information about the outline character. If this value is <b>null</b>, the function returns the required size of the buffer.</param>
		/// <param name="lpmat2">A <see cref="Mat2"/> structure specifying a transformation matrix for the character.</param>
		/// <returns>
		/// If <see cref="GGO.BITMAP"/>, <see cref="GGO.GRAY2_BITMAP"/>, <see cref="GGO.GRAY4_BITMAP"/>, <see cref="GGO.GRAY8_BITMAP"/>, or <see cref="GGO.NATIVE"/> is specified and the function succeeds,
		/// the return value is greater than zero; otherwise, the return value is <b>GDI_ERROR</b> (-1). If one of these flags is specified and the buffer size or address is zero, the return value specifies the
		/// required buffer size, in bytes. If <see cref="GGO.METRICS"/> is specified and the function fails, the return value is <b>GDI_ERROR</b> (-1).
		/// </returns>
		[DllImport(DLLName, EntryPoint=GetGlyphOutlineW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public static extern uint GetGlyphOutline(HDC hdc, uint uChar, GGO uFormat, out GlyphMetrics lpgm, uint cbBuffer, byte[] lpvBuffer, [In] ref Mat2 lpmat2);

		/// <summary>
		/// The <b>GetGlyphOutline</b> function retrieves the outline or bitmap for a character in the TrueType font that is selected into the specified device context.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="uChar">The character for which data is to be returned.</param>
		/// <param name="uFormat">A <see cref="GGO"/> specifying the format of the data that the function retrieves.</param>
		/// <param name="lpgm">Returns a <see cref="GlyphMetrics"/> structure describing the placement of the glyph in the character cell.</param>
		/// <param name="cbBuffer">The size, in bytes, of the buffer (<paramref name="lpvBuffer"/>) where the function is to copy information about the outline character. If this value is zero, the function returns the required size of the buffer.</param>
		/// <param name="lpvBuffer">The buffer that receives information about the outline character. If this value is <b>IntPtr.Zero</b>, the function returns the required size of the buffer.</param>
		/// <param name="lpmat2">A <see cref="Mat2"/> structure specifying a transformation matrix for the character.</param>
		/// <returns>
		/// If <see cref="GGO.BITMAP"/>, <see cref="GGO.GRAY2_BITMAP"/>, <see cref="GGO.GRAY4_BITMAP"/>, <see cref="GGO.GRAY8_BITMAP"/>, or <see cref="GGO.NATIVE"/> is specified and the function succeeds,
		/// the return value is greater than zero; otherwise, the return value is <b>GDI_ERROR</b>. If one of these flags is specified and the buffer size or address is zero, the return value specifies the
		/// required buffer size, in bytes. If <see cref="GGO.METRICS"/> is specified and the function fails, the return value is <b>GDI_ERROR</b>.
		/// </returns>
		[DllImport(DLLName, EntryPoint=GetGlyphOutlineW, CharSet=CharSet.Unicode, ExactSpelling=true)]
		public static extern uint GetGlyphOutline(HDC hdc, uint uChar, GGO uFormat, out GlyphMetrics lpgm, uint cbBuffer, IntPtr lpvBuffer, [In] ref Mat2 lpmat2);
	}
}
