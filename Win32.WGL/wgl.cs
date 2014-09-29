#region Copyrights and Licenses
// Win32 API
//
// Copyright (c) 1985-95, Microsoft Corporation
//
// wglext.h
//
// Copyright (c) 2013-2014 The Khronos Group Inc.
// Copyright (c) of C# port 2014 by Shinta <shintadono@googlemail.com>
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and/or associated documentation files (the
// "Materials"), to deal in the Materials without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Materials, and to
// permit persons to whom the Materials are furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Materials.
//
// THE MATERIALS ARE PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
// CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
// MATERIALS OR THE USE OR OTHER DEALINGS IN THE MATERIALS.
#endregion

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using OpenGL.Core;
using OpenGL.Compatibility;
using HANDLE=System.IntPtr;
using HDC=System.IntPtr;
using HGLRC=System.IntPtr;
using HPBUFFERARB=System.IntPtr;

namespace Win32.WGL
{
	using Delegates;

	namespace Delegates
	{
		#region WGL_ARB_create_context(-profile)
		internal delegate HGLRC wglCreateContextAttribsARB(HDC hDC, HGLRC hShareContext, int[] attribList);
		#endregion

		#region WGL_ARB_extensions_string
		internal delegate IntPtr wglGetExtensionsStringARB(HDC hdc);
		#endregion

		#region WGL_ARB_make_current_read
		/// <summary>
		/// Makes the device context(s) and rendering context current.
		/// </summary>
		/// <param name="hDrawDC">The handle to the device context for drawing.</param>
		/// <param name="hReadDC">The handle to the device context for reading.</param>
		/// <param name="hglrc">The handle to the rendering context.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public delegate bool wglMakeContextCurrentARB(HDC hDrawDC, HDC hReadDC, HGLRC hglrc);

		/// <summary>
		/// Returns the current device context for reading.
		/// </summary>
		/// <returns>The handle to the device context for reading.</returns>
		public delegate HDC wglGetCurrentReadDCARB();
		#endregion

		#region WGL_ARB_buffer_region
		/// <summary>
		/// Creates a buffer region.
		/// </summary>
		/// <param name="hDC">The handle to the device context.</param>
		/// <param name="iLayerPlane">The layer plane.</param>
		/// <param name="uType">A <see cref="wglBufferMaskARB"/>-bitmask specifying the buffers,</param>
		/// <returns>A handle to the buffer region object.</returns>
		public delegate HANDLE wglCreateBufferRegionARB(HDC hDC, int iLayerPlane, wglBufferMaskARB uType);

		/// <summary>
		/// Deletes a buffer region.
		/// </summary>
		/// <param name="hRegion">The handle to the buffer region object.</param>
		public delegate void wglDeleteBufferRegionARB(HANDLE hRegion);

		/// <summary>
		/// Saves the content of the buffer(s) specified for the buffer region object to the buffer region.
		/// </summary>
		/// <param name="hRegion">The handle to the buffer region object.</param>
		/// <param name="x">The start position of the region in x-direction.</param>
		/// <param name="y">The start position of the region in y-direction.</param>
		/// <param name="width">The width of the region.</param>
		/// <param name="height">The height of the region.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public delegate bool wglSaveBufferRegionARB(HANDLE hRegion, int x, int y, int width, int height);

		/// <summary>
		/// Restores the content of the buffer(s) specified for the buffer region object with the content save in the buffer region.
		/// </summary>
		/// <param name="hRegion">The handle to the buffer region object.</param>
		/// <param name="x">The start position of the region in x-direction.</param>
		/// <param name="y">The start position of the region in x-direction.</param>
		/// <param name="width">The width of the region.</param>
		/// <param name="height">The height of the region.</param>
		/// <param name="xSrc">The start position of the region inside the buffer region in x-direction.</param>
		/// <param name="ySrc">The start position of the region inside the buffer region in y-direction.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public delegate bool wglRestoreBufferRegionARB(HANDLE hRegion, int x, int y, int width, int height, int xSrc, int ySrc);
		#endregion

		#region WGL_ARB_pixel_format
		internal delegate bool wglGetPixelFormatAttribivARB_out(HDC hdc, int iPixelFormat, int iLayerPlane, uint one, ref wglPixelFormatAttributeARB piAttributes, out int piValues);
		internal delegate bool wglGetPixelFormatAttribivARB_array(HDC hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, wglPixelFormatAttributeARB[] piAttributes, int[] piValues);
		internal delegate bool wglGetPixelFormatAttribfvARB_out(HDC hdc, int iPixelFormat, int iLayerPlane, uint one, ref wglPixelFormatAttributeARB piAttributes, out float pfValues);
		internal delegate bool wglGetPixelFormatAttribfvARB_array(HDC hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, wglPixelFormatAttributeARB[] piAttributes, float[] pfValues);
		internal delegate bool wglChoosePixelFormatARB_out(HDC hdc, int[] piAttribIList, float[] pfAttribFList, uint one, out int piFormat, out uint nNumFormats);
		internal delegate bool wglChoosePixelFormatARB_array(HDC hdc, int[] piAttribIList, float[] pfAttribFList, uint nMaxFormats, int[] piFormats, out uint nNumFormats);
		#endregion

		#region WGL_ARB_pbuffer
		internal delegate HPBUFFERARB wglCreatePbufferARB(HDC hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList);

		/// <summary>
		/// Creates a device context of a pbuffer.
		/// </summary>
		/// <param name="hPbuffer">The handle to the pbuffer.</param>
		/// <returns>The handle to the device context.</returns>
		public delegate HDC wglGetPbufferDCARB(HPBUFFERARB hPbuffer);

		/// <summary>
		/// Releases a device context previously created with <see cref="wgl.GetPbufferDCARB"/>.
		/// </summary>
		/// <param name="hPbuffer">The handle to the pbuffer.</param>
		/// <param name="hDC">The handle to the device context.</param>
		/// <returns><b>1</b> if the device context was released, otherwise <b>0</b> is returned.</returns>
		public delegate int wglReleasePbufferDCARB(HPBUFFERARB hPbuffer, HDC hDC);

		/// <summary>
		/// Destroys a pbuffer.
		/// </summary>
		/// <param name="hPbuffer">The handle to the pbuffer.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public delegate bool wglDestroyPbufferARB(HPBUFFERARB hPbuffer);

		internal delegate bool wglQueryPbufferARB(HPBUFFERARB hPbuffer, wglPbufferAttributeARB iAttribute, out int piValue);
		#endregion

		#region WGL_ARB_render_texture
		internal delegate bool wglSetPbufferAttribARB(HPBUFFERARB hPbuffer, int[] piAttribList);

		/// <summary>
		/// Defines/binds a texture based on a pbuffer color buffer.
		/// </summary>
		/// <param name="hPbuffer">The handle to the pbuffer.</param>
		/// <param name="iBuffer">A <see cref="wglBufferARB"/> specifying the buffer.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public delegate bool wglBindTexImageARB(HPBUFFERARB hPbuffer, wglBufferARB iBuffer);

		/// <summary>
		/// Releases a texture binding from a pbuffer.
		/// </summary>
		/// <param name="hPbuffer">The handle to the pbuffer.</param>
		/// <param name="iBuffer">A <see cref="wglBufferARB"/> specifying the buffer.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public delegate bool wglReleaseTexImageARB(HPBUFFERARB hPbuffer, wglBufferARB iBuffer);
		#endregion

		#region WGL_EXT_swap_control
		/// <summary>
		/// Returns the interval of minimum periodicity of color buffer swaps, measured in video frame periods.
		/// </summary>
		/// <returns>The interval of minimum periodicity of color buffer swaps, measured in video frame periods.</returns>
		public delegate int wglGetSwapIntervalEXT();

		/// <summary>
		/// Sets the interval of minimum periodicity of color buffer swaps, measured in video frame periods.
		/// </summary>
		/// <param name="interval">The interval of minimum periodicity of color buffer swaps, measured in video frame periods.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public delegate bool wglSwapIntervalEXT(int interval);
		#endregion

		#region WGL_NV_copy_image (wgl sibling of glCopyImageSubData, available since 4.3)
		/// <summary>
		/// Performs a raw data copy between two images.
		/// </summary>
		/// <param name="hSrcRC">The handle to the source rendering context.</param>
		/// <param name="srcName">The name of a texture or renderbuffer object from which to copy.</param>
		/// <param name="srcTarget">A <see cref="glTextureTarget"/> specifying the namespaces of <paramref name="srcName"/>.</param>
		/// <param name="srcLevel">The level-of-detail to read form the source.</param>
		/// <param name="srcX">The X coordinate of the left edge of the souce region to copy.</param>
		/// <param name="srcY">The Y coordinate of the left edge of the souce region to copy.</param>
		/// <param name="srcZ">The Z coordinate of the left edge of the souce region to copy.</param>
		/// <param name="hDstRC">The handle to the destination rendering context.</param>
		/// <param name="dstName">The name of a texture or renderbuffer object to which to copy.</param>
		/// <param name="dstTarget">A <see cref="glTextureTarget"/> specifying the namespaces of <paramref name="dstName"/>.</param>
		/// <param name="dstLevel">The level-of-detail of the target to write to.</param>
		/// <param name="dstX">The X coordinate of the left edge of the destination region.</param>
		/// <param name="dstY">The Y coordinate of the left edge of the destination region.</param>
		/// <param name="dstZ">The Z coordinate of the left edge of the destination region.</param>
		/// <param name="srcWidth">The width of the region.</param>
		/// <param name="srcHeight">The height of the region.</param>
		/// <param name="srcDepth">The depth of the region.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public delegate bool wglCopyImageSubDataNV(HGLRC hSrcRC, uint srcName, glTextureTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, HGLRC hDstRC, uint dstName, glTextureTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
		#endregion
	}

	/// <summary>
	/// OpenGL window binding for the Microsoft Windows OS.
	/// </summary>
	[SuppressUnmanagedCodeSecurityAttribute()]
	public static class wgl
	{
		const string DLLName="OPENGL32.DLL";
		const string TypeNotSupportedMessage="Type not supported.";

		#region Renderer properties
		/// <summary>
		/// After <see cref="LoadWGLExtensions"/> was called, this property contains the version string of the OpenGL implementation used.
		/// </summary>
		public static string Version { get; private set; }

		/// <summary>
		/// After <see cref="LoadWGLExtensions"/> was called, this property contains the vendor name of the OpenGL implementation used.
		/// </summary>
		public static string Vendor { get; private set; }

		/// <summary>
		/// After <see cref="LoadWGLExtensions"/> was called, this property contains the renderer name of the OpenGL implementation used.
		/// </summary>
		public static string Renderer { get; private set; }

		static int majorVersion=1;

		/// <summary>
		/// After <see cref="LoadWGLExtensions"/> was called, this property contains the major version number of the OpenGL implementation used.
		/// </summary>
		public static int MajorVersion { get { return majorVersion; } private set { majorVersion=value; } }

		static int minorVersion=1;

		/// <summary>
		/// After <see cref="LoadWGLExtensions"/> was called, this property contains the minor version number of the OpenGL implementation used.
		/// </summary>
		public static int MinorVersion { get { return minorVersion; } private set { minorVersion=value; } }
		#endregion

		/// <summary>
		/// Maximum number of (layered) buffer swap operations that can be performed at once (with <see cref="SwapMultipleBuffers">wgl.SwapMultipleBuffers</see>).
		/// </summary>
		public const int SwapMultipleMax=16;

		#region Original wgl functions
		/// <summary>
		/// Copies selected groups of rendering states from one OpenGL rendering context to another.
		/// </summary>
		/// <param name="hglrcSrc">Specifies the source OpenGL rendering context whose state information is to be copied.</param>
		/// <param name="hglrcDst">Specifies the destination OpenGL rendering context to which state information is to be copied.</param>
		/// <param name="mask">Specifies which groups of the <paramref name="hglrcSrc"/> rendering state are to be copied to <paramref name="hglrcDst"/>.
		/// It contains the bitwise-OR of the same symbolic names that are passed to the glPushAttrib function.
		/// You can use <see cref="glAttribMask.ALL_ATTRIB_BITS"/> to copy all the rendering state information.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[Obsolete("Stashing of context attributes is not supported in the OpenGL core profile anymore.")]
		[DllImport(DLLName, EntryPoint="wglCopyContext")]
		public static extern bool CopyContext(HGLRC hglrcSrc, HGLRC hglrcDst, glAttribMask mask);

		/// <summary>
		/// Creates a new OpenGL rendering context, which is suitable for drawing on the device referenced by <paramref name="hdc"/>. The rendering context has the same pixel format as the device context.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <returns>The handle to the rendering context.</returns>
		[DllImport(DLLName, EntryPoint="wglCreateContext")]
		public static extern HGLRC CreateContext(HDC hdc);

		/// <summary>
		/// Creates a new OpenGL rendering context for drawing to a specified layer plane on a device context.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="iLayerPlane">The layer plane to which you want to bind a rendering context.</param>
		/// <returns>The handle to the rendering context.</returns>
		[DllImport(DLLName, EntryPoint="wglCreateLayerContext")]
		public static extern HGLRC CreateLayerContext(HDC hdc, int iLayerPlane);

		/// <summary>
		/// Deletes a specified OpenGL rendering context.
		/// </summary>
		/// <param name="hglrc">The handle to the rendering context.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName, EntryPoint="wglDeleteContext")]
		public static extern bool DeleteContext(HGLRC hglrc);

		/// <summary>
		/// Obtains information about the layer planes of a given pixel format.
		/// </summary>
		/// <param name="hdc">The handle to the device context of a window whose layer planes are to be described.</param>
		/// <param name="iPixelFormat">The pixel format to be described.</param>
		/// <param name="iLayerPlane">The layer plane number. Positive number are overlay planes, negative numbers are underlay planes.</param>
		/// <param name="nBytes">The size, in bytes, of the structure pointed to by plpd.</param>
		/// <param name="plpd">Returns the description of the layer plane.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName, EntryPoint="wglDescribeLayerPlane")]
		public static extern bool DescribeLayerPlane(HDC hdc, int iPixelFormat, int iLayerPlane, uint nBytes, out LayerPlaneDescriptor plpd);

		/// <summary>
		/// Obtains a handle to the current OpenGL rendering context of the calling thread.
		/// </summary>
		/// <returns>The handle to the rendering context.</returns>
		[DllImport(DLLName, EntryPoint="wglGetCurrentContext")]
		public static extern HGLRC GetCurrentContext();

		/// <summary>
		/// Obtains a handle to the device context that is associated with the current OpenGL rendering context of the calling thread.
		/// </summary>
		/// <returns>The handle to the device context.</returns>
		[DllImport(DLLName, EntryPoint="wglGetCurrentDC")]
		public static extern HDC GetCurrentDC();

		/// <summary>
		/// Retrieves the palette entries from a given color-index layer plane for a specified device context.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="iLayerPlane">The layer plane.</param>
		/// <param name="iStart">The first palette entry to be retrieved.</param>
		/// <param name="cEntries">The number of palette entries to be retrieved.</param>
		/// <param name="plpd">Returns an array of palette RGB color values. The array must contain at least as many structures as specified by <paramref name="cEntries"/>.</param>
		/// <returns>If the function succeeds, the return value is the number of entries that were set in the palette in the specified layer plane of the window. Otherwise zero is returned.</returns>
		[Obsolete("Palettes and indexed colors aren't supported in the OpenGL core profile anymore.")]
		[DllImport(DLLName, EntryPoint="wglGetLayerPaletteEntries")]
		public static extern int GetLayerPaletteEntries(HDC hdc, int iLayerPlane, int iStart, int cEntries, uint[] plpd);

		[DllImport(DLLName, EntryPoint="wglGetProcAddress")]
		private static extern IntPtr _GetProcAddress(string lpszProc);

		/// <summary>
		/// Makes a specified OpenGL rendering context the calling thread's current rendering context.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="hglrc">The handle to the rendering context.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName, EntryPoint="wglMakeCurrent")]
		public static extern bool MakeCurrent(HDC hdc, HGLRC hglrc);

		/// <summary>
		/// Maps palette entries from a given color-index layer plane into the physical palette or initializes the palette of an RGBA layer plane.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="iLayerPlane">The layer plane.</param>
		/// <param name="bRealize">Set <b>true</b> to map palette entries into the physical palette; set <b>false</b>
		/// if the layer plane of the window are no longer needed and might be released for use by another foreground window.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[Obsolete("Palettes and indexed colors aren't supported in the OpenGL core profile anymore.")]
		[DllImport(DLLName, EntryPoint="wglRealizeLayerPalette")]
		public static extern bool RealizeLayerPalette(HDC hdc, int iLayerPlane, bool bRealize);

		/// <summary>
		/// Sets the palette entries in a given color-index layer plane for a specified device context.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="iLayerPlane">The layer plane.</param>
		/// <param name="iStart">The first palette entry to be retrieved.</param>
		/// <param name="cEntries">The number of palette entries to be retrieved.</param>
		/// <param name="plpd">An array of palette RGB color values. The array must contain at least as many structures as specified by <paramref name="cEntries"/>.</param>
		/// <returns>If the function succeeds, the return value is the number of entries that were set in the palette in the specified layer plane of the window. Otherwise zero is returned.</returns>
		[Obsolete("Palettes and indexed colors aren't supported in the OpenGL core profile anymore.")]
		[DllImport(DLLName, EntryPoint="wglSetLayerPaletteEntries")]
		public static extern int SetLayerPaletteEntries(HDC hdc, int iLayerPlane, int iStart, int cEntries, uint[] plpd);

		/// <summary>
		/// Enables multiple OpenGL rendering contexts to share object resources (e.g. display lists [deprecated], textures, VBO,...).
		/// </summary>
		/// <param name="hglrc1">The handle to the OpenGL rendering context with which to share.</param>
		/// <param name="hglrc2">The handle to the OpenGL rendering context to share with <paramref name="hglrc1"/>.
		/// The <paramref name="hglrc2"/> parameter should not contain any existing resources when <see cref="ShareLists">wgl.ShareLists</see> is called.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName, EntryPoint="wglShareLists")]
		public static extern bool ShareLists(HGLRC hglrc1, HGLRC hglrc2);

		/// <summary>
		/// Swaps the front and back buffers in the overlay, underlay, and main planes of the window referenced by a specified device context.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="fuPlanes"><see cref="WGL_SWAP"/>-bitmask specifying the planes to be swapped.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[DllImport(DLLName, EntryPoint="wglSwapLayerBuffers")]
		public static extern bool SwapLayerBuffers(HDC hdc, WGL_SWAP fuPlanes);

		/// <summary>
		/// Allows to swap more than one window at one time.
		/// </summary>
		/// <remarks>For example if you have four views like in a CAD application, if you call
		/// <see cref="wgl.SwapLayerBuffers"/> or <b>SwapBuffers</b> (GDI) in sequence
		/// for each of them there is a small delay because it's a blocking call. It's annoying
		/// during playback of animation, because the contexts can be seen to swaping clockwise,
		/// for example (though it can be minimized). It's probably not implemented, like the
		/// DirectDraw flag (good intension only).
		/// </remarks>
		/// <param name="count">The number of swaps to perform. Maximum is defined by <see cref="wgl.SwapMultipleMax"/>.</param>
		/// <param name="swaps">An array of at least <paramref name="count"/> <see cref="WGLSwap"/> structures specifying the (layered) buffer swap operations to perform.</param>
		/// <returns>Returns the number of perfomed swap operations.</returns>
		[DllImport(DLLName, EntryPoint="wglSwapMultipleBuffers")]
		public static extern uint SwapMultipleBuffers(uint count, WGLSwap[] swaps);

		/// <summary>
		/// Creates a set of bitmap display lists for use in the current OpenGL rendering context.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="first">Specifies the first glyph in the run of glyphs that will be used to form glyph bitmap display lists.</param>
		/// <param name="count">Specifies the number of glyphs in the run of glyphs that will be used to form glyph bitmap display lists.
		/// The function creates count display lists, one for each glyph in the run.</param>
		/// <param name="listBase">Specifies a starting display list.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[Obsolete("Display list aren't supported in the OpenGL core profile anymore.")]
		[DllImport(DLLName, EntryPoint="wglUseFontBitmapsW")]
		public static extern bool UseFontBitmaps(HDC hdc, uint first, uint count, uint listBase);

		/// <summary>
		/// Creates a set of display lists, one for each glyph of the currently selected outline font
		/// of a device context, for use with the current rendering context.
		/// </summary>
		/// <param name="hdc">The handle to the device context.</param>
		/// <param name="first">Specifies the first glyph in the set of glyphs that form the font outline display lists.</param>
		/// <param name="count">Specifies the number of glyphs in the set of glyphs used to form the font outline display lists.
		/// The function creates count display lists, one display list for each glyph in a set of glyphs.</param>
		/// <param name="listBase">Specifies a starting display list.</param>
		/// <param name="deviation">Specifies the maximum chordal deviation from the original outlines.</param>
		/// <param name="extrusion">Specifies how much a font is extruded in the negative z direction.</param>
		/// <param name="format">A <see cref="WGL_FONT"/> specifying the format to use in the display lists.</param>
		/// <param name="lpgmf">Points to an array of <paramref name="count"/> <see cref="GlyphMetricsFloat"/> structures that
		/// is to receive the metrics of the glyphs. When lpgmf is <b>null</b>, no glyph metrics are returned.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		[Obsolete("Display list aren't supported in the OpenGL core profile anymore.")]
		[DllImport(DLLName, EntryPoint="wglUseFontOutlinesW")]
		public static extern bool UseFontOutlines(HDC hdc, uint first, uint count, uint listBase, float deviation, float extrusion, WGL_FONT format, GlyphMetricsFloat[] lpgmf);
		#endregion

		#region Delegate variables
		private static wglCreateContextAttribsARB _CreateContextAttribsARB;

		private static wglGetExtensionsStringARB _GetExtensionsStringARB;

		/// <summary>
		/// Makes the device context(s) and rendering context current.
		/// </summary>
		public static wglMakeContextCurrentARB MakeContextCurrentARB;

		/// <summary>
		/// Returns the current device context for reading.
		/// </summary>
		public static wglGetCurrentReadDCARB GetCurrentReadDCARB;

		/// <summary>
		/// Creates a buffer region.
		/// </summary>
		public static wglCreateBufferRegionARB CreateBufferRegionARB;

		/// <summary>
		/// Deletes a buffer region.
		/// </summary>
		public static wglDeleteBufferRegionARB DeleteBufferRegionARB;

		/// <summary>
		/// Saves the content of the buffer(s) specified for the buffer region object to the buffer region.
		/// </summary>
		public static wglSaveBufferRegionARB SaveBufferRegionARB;

		/// <summary>
		/// Restores the content of the buffer(s) specified for the buffer region object with the content save in the buffer region.
		/// </summary>
		public static wglRestoreBufferRegionARB RestoreBufferRegionARB;

		private static wglGetPixelFormatAttribivARB_out GetPixelFormatAttribivARB_out;
		private static wglGetPixelFormatAttribivARB_array GetPixelFormatAttribivARB_array;
		private static wglGetPixelFormatAttribfvARB_out GetPixelFormatAttribfvARB_out;
		private static wglGetPixelFormatAttribfvARB_array GetPixelFormatAttribfvARB_array;
		private static wglChoosePixelFormatARB_out ChoosePixelFormatARB_out;
		private static wglChoosePixelFormatARB_array ChoosePixelFormatARB_array;
		private static wglCreatePbufferARB _CreatePbufferARB;

		/// <summary>
		/// Creates a device context of a pbuffer.
		/// </summary>
		public static wglGetPbufferDCARB GetPbufferDCARB;

		/// <summary>
		/// Releases a device context previously created with <see cref="wgl.GetPbufferDCARB"/>.
		/// </summary>
		public static wglReleasePbufferDCARB ReleasePbufferDCARB;

		/// <summary>
		/// Destroys a pbuffer.
		/// </summary>
		public static wglDestroyPbufferARB DestroyPbufferARB;

		private static wglQueryPbufferARB _QueryPbufferARB;
		private static wglSetPbufferAttribARB _SetPbufferAttribARB;

		/// <summary>
		/// Defines/binds a texture based on a pbuffer color buffer.
		/// </summary>
		public static wglBindTexImageARB BindTexImageARB;

		/// <summary>
		/// Releases a texture binding from a pbuffer.
		/// </summary>
		public static wglReleaseTexImageARB ReleaseTexImageARB;

		/// <summary>
		/// Returns the interval of minimum periodicity of color buffer swaps, measured in video frame periods.
		/// </summary>
		public static wglGetSwapIntervalEXT GetSwapIntervalEXT;

		/// <summary>
		/// Sets the interval of minimum periodicity of color buffer swaps, measured in video frame periods.
		/// </summary>
		public static wglSwapIntervalEXT SwapIntervalEXT;

		/// <summary>
		/// Performs a raw data copy between two images.
		/// </summary>
		public static wglCopyImageSubDataNV CopyImageSubDataNV;
		#endregion

		#region Overrides/Overloads
		/// <summary>
		/// Returns a delegate of type <typeparamref name="TDelegate"/> to an OpenGL (extension) function for use with the current OpenGL rendering context.
		/// </summary>
		/// <typeparam name="TDelegate">The type of delegate to return.</typeparam>
		/// <param name="name">The name of the (extension) function.</param>
		/// <returns>The address of an OpenGL (extension) function.</returns>
		public static TDelegate GetProcAddress<TDelegate>(string name) where TDelegate : class
		{
			IntPtr addr=wgl._GetProcAddress(name);
			if(addr==IntPtr.Zero) return null;
			return (TDelegate)(object)Marshal.GetDelegateForFunctionPointer(addr, typeof(TDelegate));
		}

		/// <summary>
		/// Creates a new OpenGL rendering context that, if successful created, will satisfy all the user-specified demands.
		/// </summary>
		/// <param name="hDC">The handle to the device context.</param>
		/// <param name="hShareContext">A handle to a rendering context with which to share objects. Set <b>0</b> (zero) if no sharing is needed.</param>
		/// <param name="attribList">A null-terminated list of attributes (name-value pairs) for the rendering context.</param>
		/// <returns>The handle to the rendering context.</returns>
		public static HGLRC CreateContextAttribsARB(HDC hDC, HGLRC hShareContext, params int[] attribList)
		{
			return _CreateContextAttribsARB(hDC, hShareContext, attribList);
		}

		/// <summary>
		/// Creates a new OpenGL rendering context that, if successful created, will satisfy all the user-specified demands.
		/// </summary>
		/// <param name="hDC">The handle to the device context.</param>
		/// <param name="hShareContext">A handle to a rendering context with which to share objects. Set <b>0</b> (zero) if no sharing is needed.</param>
		/// <param name="pAttribList">A dictionary containing the attributes for the pixel format.</param>
		/// <returns>The handle to the rendering context.</returns>
		public static HGLRC CreateContextAttribsARB(HDC hDC, HGLRC hShareContext, Dictionary<wglContextAttributeARB, object> pAttribList)
		{
			if(pAttribList==null||pAttribList.Count==0) return HGLRC.Zero;

			int[] piAttribList=new int[pAttribList.Count*2+1];
			int ints=0;

			foreach(wglContextAttributeARB key in pAttribList.Keys)
			{
				if(key==0) continue;
				object value=pAttribList[key];

				if(!(value is int||value is uint||value is bool||value is Enum)) continue;

				if(value is int) piAttribList[ints+1]=(int)value;
				else if(value is uint) piAttribList[ints+1]=(int)(uint)value;
				else if(value is bool) piAttribList[ints+1]=((bool)value)?gl.TRUE:gl.FALSE;
				else if(value is Enum)
				{
					Type vType=value.GetType().GetEnumUnderlyingType();
					if(vType.Equals(typeof(int))) piAttribList[ints+1]=(int)value;
					else if(vType.Equals(typeof(uint))) piAttribList[ints+1]=(int)(uint)value;
					else continue;
				}

				piAttribList[ints]=(int)key;
				ints+=2;

				continue;
			}

			piAttribList[ints]=0;

			return _CreateContextAttribsARB(hDC, hShareContext, piAttribList);
		}

		/// <summary>
		/// Returns a list of supported wgl-extensions.
		/// </summary>
		/// <param name="hdc">The device context to query extensions for.</param>
		/// <returns>A list of supported wgl-extensions as <b>string</b>.</returns>
		public static string GetExtensionsStringARB(HDC hdc)
		{
			return Marshal.PtrToStringAnsi(_GetExtensionsStringARB(hdc));
		}

		/// <summary>
		/// Retrieves information about pixel formats.
		/// </summary>
		/// <param name="hdc">The device context to query informations for.</param>
		/// <param name="iPixelFormat">The pixel format to query informations for.</param>
		/// <param name="iLayerPlane">The layer plane.</param>
		/// <param name="piAttributes">A <see cref="wglPixelFormatAttributeARB"/> specifying the attribute.</param>
		/// <param name="piValue">Returns the requested information.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool GetPixelFormatAttribivARB(HDC hdc, int iPixelFormat, int iLayerPlane, wglPixelFormatAttributeARB piAttributes, out int piValue)
		{
			return GetPixelFormatAttribivARB_out(hdc, iPixelFormat, iLayerPlane, 1, ref piAttributes, out piValue);
		}

		/// <summary>
		/// Retrieves information about pixel formats.
		/// </summary>
		/// <param name="hdc">The device context to query informations for.</param>
		/// <param name="iPixelFormat">The pixel format to query informations for.</param>
		/// <param name="iLayerPlane">The layer plane.</param>
		/// <param name="piAttributes">A <see cref="wglPixelFormatAttributeARB"/> specifying the attribute.</param>
		/// <param name="pbValue">Returns the requested information.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool GetPixelFormatAttribivARB(HDC hdc, int iPixelFormat, int iLayerPlane, wglPixelFormatAttributeARB piAttributes, out bool pbValue)
		{
			int value;
			bool ret=GetPixelFormatAttribivARB_out(hdc, iPixelFormat, iLayerPlane, 1, ref piAttributes, out value);
			pbValue=value!=0;
			return ret;
		}

		/// <summary>
		/// Retrieves acceleration mode (<see cref="wglPixelFormatAttributeARB.ACCELERATION_ARB"/>) of a pixel format.
		/// </summary>
		/// <param name="hdc">The device context to query informations for.</param>
		/// <param name="iPixelFormat">The pixel format to query informations for.</param>
		/// <param name="iLayerPlane">The layer plane.</param>
		/// <param name="piValue">Returns the acceleration mode as <see cref="wglAccelerationModeARB"/>.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool GetPixelFormatAttribivARB(HDC hdc, int iPixelFormat, int iLayerPlane, out wglAccelerationModeARB piValue)
		{
			wglPixelFormatAttributeARB piAttributes=wglPixelFormatAttributeARB.ACCELERATION_ARB;
			int value;
			bool ret=GetPixelFormatAttribivARB_out(hdc, iPixelFormat, iLayerPlane, 1, ref piAttributes, out value);
			piValue=(wglAccelerationModeARB)value;
			return ret;
		}

		/// <summary>
		/// Retrieves swap methode (<see cref="wglPixelFormatAttributeARB.SWAP_METHOD_ARB"/>) of a pixel format.
		/// </summary>
		/// <param name="hdc">The device context to query informations for.</param>
		/// <param name="iPixelFormat">The pixel format to query informations for.</param>
		/// <param name="iLayerPlane">The layer plane.</param>
		/// <param name="piValue">Returns the swap methode as <see cref="wglSwapMethodeARB"/>.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool GetPixelFormatAttribivARB(HDC hdc, int iPixelFormat, int iLayerPlane, out wglSwapMethodeARB piValue)
		{
			wglPixelFormatAttributeARB piAttributes=wglPixelFormatAttributeARB.SWAP_METHOD_ARB;
			int value;
			bool ret=GetPixelFormatAttribivARB_out(hdc, iPixelFormat, iLayerPlane, 1, ref piAttributes, out value);
			piValue=(wglSwapMethodeARB)value;
			return ret;
		}

		/// <summary>
		/// Retrieves pixel type (<see cref="wglPixelFormatAttributeARB.PIXEL_TYPE_ARB"/>) of a pixel format.
		/// </summary>
		/// <param name="hdc">The device context to query informations for.</param>
		/// <param name="iPixelFormat">The pixel format to query informations for.</param>
		/// <param name="iLayerPlane">The layer plane.</param>
		/// <param name="piValue">Returns the spixel type as <see cref="wglPixelTypeARB"/>.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool GetPixelFormatAttribivARB(HDC hdc, int iPixelFormat, int iLayerPlane, out wglPixelTypeARB piValue)
		{
			wglPixelFormatAttributeARB piAttributes=wglPixelFormatAttributeARB.PIXEL_TYPE_ARB;
			int value;
			bool ret=GetPixelFormatAttribivARB_out(hdc, iPixelFormat, iLayerPlane, 1, ref piAttributes, out value);
			piValue=(wglPixelTypeARB)value;
			return ret;
		}

		/// <summary>
		/// Retrieves information about pixel formats.
		/// </summary>
		/// <param name="hdc">The device context to query informations for.</param>
		/// <param name="iPixelFormat">The pixel format to query informations for.</param>
		/// <param name="iLayerPlane">The layer plane.</param>
		/// <param name="piAttributes">An array of <see cref="wglPixelFormatAttributeARB"/>s specifying the attributes.</param>
		/// <param name="piValues">The array to receive the requested values.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool GetPixelFormatAttribivARB(HDC hdc, int iPixelFormat, int iLayerPlane, wglPixelFormatAttributeARB[] piAttributes, int[] piValues)
		{
			return GetPixelFormatAttribivARB_array(hdc, iPixelFormat, iLayerPlane, (uint)Math.Min(piAttributes.Length, piValues.Length), piAttributes, piValues);
		}

		/// <summary>
		/// Retrieves information about pixel formats.
		/// </summary>
		/// <param name="hdc">The device context to query informations for.</param>
		/// <param name="iPixelFormat">The pixel format to query informations for.</param>
		/// <param name="iLayerPlane">The layer plane.</param>
		/// <param name="pfAttributes">A <see cref="wglPixelFormatAttributeARB"/> specifying the attribute.</param>
		/// <param name="pfValue">Returns the requested information.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool GetPixelFormatAttribfvARB(HDC hdc, int iPixelFormat, int iLayerPlane, wglPixelFormatAttributeARB pfAttributes, out float pfValue)
		{
			return GetPixelFormatAttribfvARB_out(hdc, iPixelFormat, iLayerPlane, 1, ref pfAttributes, out pfValue);
		}

		/// <summary>
		/// Retrieves information about pixel formats.
		/// </summary>
		/// <param name="hdc">The device context to query informations for.</param>
		/// <param name="iPixelFormat">The pixel format to query informations for.</param>
		/// <param name="iLayerPlane">The layer plane.</param>
		/// <param name="pfAttributes">An array of <see cref="wglPixelFormatAttributeARB"/>s specifying the attributes.</param>
		/// <param name="pfValues">The array to receive the requested values.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool GetPixelFormatAttribfvARB(HDC hdc, int iPixelFormat, int iLayerPlane, wglPixelFormatAttributeARB[] pfAttributes, float[] pfValues)
		{
			return GetPixelFormatAttribfvARB_array(hdc, iPixelFormat, iLayerPlane, (uint)Math.Min(pfAttributes.Length, pfValues.Length), pfAttributes, pfValues);
		}

		/// <summary>
		/// Returns the best fitting pixel format for given attributes.
		/// </summary>
		/// <param name="hdc">The device context to query informations for.</param>
		/// <param name="piAttribIList">Null-terminated list of key-value-pairs (integers and enums) specifying the attributes for the pixel format.</param>
		/// <param name="pfAttribFList">Null-terminated list of key-value-pairs (floating point values) specifying the attributes for the pixel format.</param>
		/// <param name="piFormat">Returns the pixel format.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool ChoosePixelFormatARB(HDC hdc, int[] piAttribIList, float[] pfAttribFList, out int piFormat)
		{
			uint nNumFormats;
			bool ret=ChoosePixelFormatARB_out(hdc, piAttribIList, pfAttribFList, 1, out piFormat, out nNumFormats);
			return ret&&nNumFormats>0; // Here should 'nNumFormats==1' be correct, but there seems to be some incorrect implementations around, that return the maximum number instead of the actual returned number.
		}

		/// <summary>
		/// Returns the best fitting pixel format for given attributes.
		/// </summary>
		/// <param name="hdc">The device context to query informations for.</param>
		/// <param name="pAttribList">A dictionary containing the attributes for the pixel format.</param>
		/// <param name="piFormat">Returns the pixel format.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool ChoosePixelFormatARB(HDC hdc, Dictionary<wglPixelFormatAttributeARB, object> pAttribList, out int piFormat)
		{
			piFormat=0;
			if(pAttribList==null||pAttribList.Count==0) return false;

			int ints=0, floats=0;
			foreach(object value in pAttribList.Values)
			{
				if(value is float||value is double) { floats++; continue; }
				if(value is int||value is uint||value is bool||value is Enum) { ints++; continue; }
				throw new NotSupportedException(TypeNotSupportedMessage);
			}

			if(ints==0&&floats==0) return false;

			int[] piAttribIList=new int[ints*2+1];
			float[] pfAttribFList=new float[floats*2+1];
			ints=0; floats=0;

			foreach(wglPixelFormatAttributeARB key in pAttribList.Keys)
			{
				if(key==0) continue;
				object value=pAttribList[key];

				if(value is float||value is double)
				{
					pfAttribFList[floats++]=(float)(int)key; // is this correct? don't we need a static_cast<float> to preserve the enum bits?
					if(value is float) pfAttribFList[floats++]=(float)value;
					else pfAttribFList[floats++]=(float)(double)value;
					continue;
				}

				if(value is int||value is uint||value is bool||value is Enum)
				{
					if(value is int) piAttribIList[ints+1]=(int)value;
					else if(value is uint) piAttribIList[ints+1]=(int)(uint)value;
					else if(value is bool) piAttribIList[ints+1]=((bool)value)?gl.TRUE:gl.FALSE;
					else if(value is Enum)
					{
						Type vType=value.GetType().GetEnumUnderlyingType();
						if(vType.Equals(typeof(int))) piAttribIList[ints+1]=(int)value;
						else if(vType.Equals(typeof(uint))) piAttribIList[ints+1]=(int)(uint)value;
						else continue;
					}

					piAttribIList[ints]=(int)key;
					ints+=2;

					continue;
				}
			}

			piAttribIList[ints]=0;
			pfAttribFList[floats]=0;

			return ChoosePixelFormatARB(hdc, piAttribIList, pfAttribFList, out piFormat);
		}

		/// <summary>
		/// Returns the best fitting pixel formats for given attributes.
		/// </summary>
		/// <param name="hdc">The device context to query informations for.</param>
		/// <param name="piAttribIList">Null-terminated list of key-value-pairs (integers and enums) specifying the attributes for the pixel format.</param>
		/// <param name="pfAttribFList">Null-terminated list of key-value-pairs (floating point values) specifying the attributes for the pixel format.</param>
		/// <param name="piFormats">Returns the pixel formats.</param>
		/// <param name="nNumFormats">Returns the number of returned pixel formats (in <paramref name="piFormats"/>).</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool ChoosePixelFormatARB(HDC hdc, int[] piAttribIList, float[] pfAttribFList, int[] piFormats, out uint nNumFormats)
		{
			nNumFormats=0;
			if(piFormats==null||piFormats.Length==0) return false;

			bool ret=ChoosePixelFormatARB_array(hdc, piAttribIList, pfAttribFList, (uint)piFormats.Length, piFormats, out nNumFormats);
			return ret&&nNumFormats>0;
		}

		/// <summary>
		/// Returns the best fitting pixel formats for given attributes.
		/// </summary>
		/// <param name="hdc">The device context to query informations for.</param>
		/// <param name="pAttribList">A dictionary containing the attributes for the pixel format.</param>
		/// <param name="piFormats">Returns the pixel formats.</param>
		/// <param name="nNumFormats">Returns the number of returned pixel formats (in <paramref name="piFormats"/>).</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool ChoosePixelFormatARB(HDC hdc, Dictionary<wglPixelFormatAttributeARB, object> pAttribList, int[] piFormats, out uint nNumFormats)
		{
			nNumFormats=0;
			if(pAttribList==null||pAttribList.Count==0||piFormats==null||piFormats.Length==0) return false;

			int ints=0, floats=0;
			foreach(object value in pAttribList.Values)
			{
				if(value is float||value is double) { floats++; continue; }
				if(value is int||value is uint||value is bool||value is Enum) { ints++; continue; }
				throw new NotSupportedException(TypeNotSupportedMessage);
			}

			if(ints==0&&floats==0) return false;

			int[] piAttribIList=new int[ints*2+1];
			float[] pfAttribFList=new float[floats*2+1];
			ints=0; floats=0;

			foreach(wglPixelFormatAttributeARB key in pAttribList.Keys)
			{
				if(key==0) continue;
				object value=pAttribList[key];

				if(value is float||value is double)
				{
					pfAttribFList[floats++]=(float)(int)key; // is this correct? don't we need a static_cast<float> to preserve the enum bits?
					if(value is float) pfAttribFList[floats++]=(float)value;
					else pfAttribFList[floats++]=(float)(double)value;
					continue;
				}

				if(value is int||value is uint||value is bool||value is Enum)
				{
					if(value is int) piAttribIList[ints+1]=(int)value;
					else if(value is uint) piAttribIList[ints+1]=(int)(uint)value;
					else if(value is bool) piAttribIList[ints+1]=((bool)value)?gl.TRUE:gl.FALSE;
					else if(value is Enum)
					{
						Type vType=value.GetType().GetEnumUnderlyingType();
						if(vType.Equals(typeof(int))) piAttribIList[ints+1]=(int)value;
						else if(vType.Equals(typeof(uint))) piAttribIList[ints+1]=(int)(uint)value;
						else continue;
					}

					piAttribIList[ints]=(int)key;
					ints+=2;

					continue;
				}
			}

			piAttribIList[ints]=0;
			pfAttribFList[floats]=0;

			return ChoosePixelFormatARB(hdc, piAttribIList, pfAttribFList, piFormats, out nNumFormats);
		}

		/// <summary>
		/// Creates a pbuffer.
		/// </summary>
		/// <param name="hDC">The handle to the device context.</param>
		/// <param name="iPixelFormat">The pixel format.</param>
		/// <param name="iWidth">The width of the pbuffer.</param>
		/// <param name="iHeight">The height of the pbuffer.</param>
		/// <param name="piAttribList">A null-terminated list of name-value pairs, specifying attributes for the pbuffer.</param>
		/// <returns>The handle to the pbuffer.</returns>
		public static HPBUFFERARB CreatePbufferARB(HDC hDC, int iPixelFormat, int iWidth, int iHeight, params int[] piAttribList)
		{
			return _CreatePbufferARB(hDC, iPixelFormat, iWidth, iHeight, piAttribList);
		}

		/// <summary>
		/// Creates a pbuffer.
		/// </summary>
		/// <param name="hDC">The handle to the device context.</param>
		/// <param name="iPixelFormat">The pixel format.</param>
		/// <param name="iWidth">The width of the pbuffer.</param>
		/// <param name="iHeight">The height of the pbuffer.</param>
		/// <param name="pAttribList">A dictionary containing the attributes for the pbuffer.</param>
		/// <returns>The handle to the pbuffer.</returns>
		public static HPBUFFERARB CreatePbufferARB(HDC hDC, int iPixelFormat, int iWidth, int iHeight, Dictionary<wglPbufferAttributeARB, object> pAttribList)
		{
			if(pAttribList==null||pAttribList.Count==0) return HPBUFFERARB.Zero;

			int[] piAttribList=new int[pAttribList.Count*2+1];
			int ints=0;

			foreach(wglPbufferAttributeARB key in pAttribList.Keys)
			{
				if(key==0) continue;
				object value=pAttribList[key];

				if(!(value is int||value is uint||value is bool||value is Enum)) continue;

				if(value is int) piAttribList[ints+1]=(int)value;
				else if(value is uint) piAttribList[ints+1]=(int)(uint)value;
				else if(value is bool) piAttribList[ints+1]=((bool)value)?gl.TRUE:gl.FALSE;
				else if(value is Enum)
				{
					Type vType=value.GetType().GetEnumUnderlyingType();
					if(vType.Equals(typeof(int))) piAttribList[ints+1]=(int)value;
					else if(vType.Equals(typeof(uint))) piAttribList[ints+1]=(int)(uint)value;
					else continue;
				}

				piAttribList[ints]=(int)key;
				ints+=2;

				continue;
			}

			piAttribList[ints]=0;

			return _CreatePbufferARB(hDC, iPixelFormat, iWidth, iHeight, piAttribList);
		}

		/// <summary>
		/// Queries attributes of pbuffers.
		/// </summary>
		/// <param name="hPbuffer">The handle to the pbuffer.</param>
		/// <param name="iAttribute">A <see cref="wglPbufferAttributeARB"/> specifying the attribute to query.</param>
		/// <param name="piValue">Returns the requested value.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool QueryPbufferARB(HPBUFFERARB hPbuffer, wglPbufferAttributeARB iAttribute, out int piValue)
		{
			return _QueryPbufferARB(hPbuffer, iAttribute, out piValue);
		}

		/// <summary>
		/// Queries attributes of pbuffers.
		/// </summary>
		/// <param name="hPbuffer">The handle to the pbuffer.</param>
		/// <param name="iAttribute">A <see cref="wglPbufferAttributeARB"/> specifying the attribute to query.</param>
		/// <param name="pbValue">Returns the requested value.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool QueryPbufferARB(HPBUFFERARB hPbuffer, wglPbufferAttributeARB iAttribute, out bool pbValue)
		{
			int piValue;
			bool ret=_QueryPbufferARB(hPbuffer, iAttribute, out piValue);
			pbValue=piValue!=0;
			return ret;
		}

		/// <summary>
		/// Queries <see cref="wglPbufferAttributeARB.TEXTURE_FORMAT_ARB"/> attribute of pbuffers.
		/// </summary>
		/// <param name="hPbuffer">The handle to the pbuffer.</param>
		/// <param name="pValue">Returns the texture format.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool QueryPbufferARB(HPBUFFERARB hPbuffer, out wglTextureFormatARB pValue)
		{
			int piValue;
			bool ret=_QueryPbufferARB(hPbuffer, wglPbufferAttributeARB.TEXTURE_FORMAT_ARB, out piValue);
			pValue=(wglTextureFormatARB)piValue;
			return ret;
		}

		/// <summary>
		/// Queries <see cref="wglPbufferAttributeARB.TEXTURE_TARGET_ARB"/> attribute of pbuffers.
		/// </summary>
		/// <param name="hPbuffer">The handle to the pbuffer.</param>
		/// <param name="pValue">Returns the texture target.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool QueryPbufferARB(HPBUFFERARB hPbuffer, out wglTextureTargetARB pValue)
		{
			int piValue;
			bool ret=_QueryPbufferARB(hPbuffer, wglPbufferAttributeARB.TEXTURE_TARGET_ARB, out piValue);
			pValue=(wglTextureTargetARB)piValue;
			return ret;
		}

		/// <summary>
		/// Queries <see cref="wglPbufferAttributeARB.CUBE_MAP_FACE_ARB"/> attribute of pbuffers.
		/// </summary>
		/// <param name="hPbuffer">The handle to the pbuffer.</param>
		/// <param name="pValue">Returns the current cube map face.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool QueryPbufferARB(HPBUFFERARB hPbuffer, out wglTextureCubeMapFaceARB pValue)
		{
			int piValue;
			bool ret=_QueryPbufferARB(hPbuffer, wglPbufferAttributeARB.CUBE_MAP_FACE_ARB, out piValue);
			pValue=(wglTextureCubeMapFaceARB)piValue;
			return ret;
		}

		/// <summary>
		/// Sets attributes of a pbuffer.
		/// </summary>
		/// <param name="hPbuffer">The handle to the pbuffer.</param>
		/// <param name="piAttribList">Null-terminated list of name-value pairs, specifying attributes for the pbuffer.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool SetPbufferAttribARB(HPBUFFERARB hPbuffer, params int[] piAttribList)
		{
			return _SetPbufferAttribARB(hPbuffer, piAttribList);
		}

		/// <summary>
		/// Sets attributes of a pbuffer.
		/// </summary>
		/// <param name="hPbuffer">The handle to the pbuffer.</param>
		/// <param name="pAttribList">Null-terminated list of name-value pairs, specifying attributes for the pbuffer.</param>
		/// <returns><b>true</b> if the function succeeds, otherwise <b>false</b>.</returns>
		public static bool SetPbufferAttribARB(HPBUFFERARB hPbuffer, Dictionary<wglPbufferAttributeARB, object> pAttribList)
		{
			if(pAttribList==null||pAttribList.Count==0) return false;

			int[] piAttribList=new int[pAttribList.Count*2+1];
			int ints=0;

			foreach(wglPbufferAttributeARB key in pAttribList.Keys)
			{
				if(key==0) continue;
				object value=pAttribList[key];

				if(!(value is int||value is uint||value is bool||value is Enum)) continue;

				if(value is int) piAttribList[ints+1]=(int)value;
				else if(value is uint) piAttribList[ints+1]=(int)(uint)value;
				else if(value is bool) piAttribList[ints+1]=((bool)value)?gl.TRUE:gl.FALSE;
				else if(value is Enum)
				{
					Type vType=value.GetType().GetEnumUnderlyingType();
					if(vType.Equals(typeof(int))) piAttribList[ints+1]=(int)value;
					else if(vType.Equals(typeof(uint))) piAttribList[ints+1]=(int)(uint)value;
					else continue;
				}

				piAttribList[ints]=(int)key;
				ints+=2;

				continue;
			}

			piAttribList[ints]=0;

			return _SetPbufferAttribARB(hPbuffer, piAttribList);
		}
		#endregion

		/// <summary>
		/// Loads available functions of the OpenGL window binding for the Microsoft Windows OS provided by the currently active ICD.
		/// </summary>
		/// <param name="updateOnly">Set <b>true</b>, if you only want to update the binding for the currently active rendering context.
		/// If set to <b>false</b>, an invisible window will be created to activate a rendering context for a ICD and then used to
		/// update the binding.</param>
		/// <returns><b>true</b> if the extensions <c>WGL_ARB_create_context(-profile)</c>, <c>WGL_ARB_make_current_read</c> and
		/// <c>WGL_ARB_pixel_format</c> are available.</returns>
		public static bool LoadWGLExtensions(bool updateOnly=false)
		{
			if(!updateOnly)
			{
				// Nothing more is needed, everything is done in the constructor, even the recursive call to this methode.
				wglInitializationDummyWindow dlg=new wglInitializationDummyWindow();
				return dlg.Success;
			}

			// Fill renderer properties
			Version=gl.GetString(glGetStringParameter.VERSION);
			Vendor=gl.GetString(glGetStringParameter.VENDOR);
			Renderer=gl.GetString(glGetStringParameter.RENDERER);
			majorVersion=gl.GetInteger(glGetIntegerParameter.MAJOR_VERSION);
			minorVersion=gl.GetInteger(glGetIntegerParameter.MINOR_VERSION);

			_CreateContextAttribsARB=GetProcAddress<wglCreateContextAttribsARB>("wglCreateContextAttribsARB");
			_GetExtensionsStringARB=GetProcAddress<wglGetExtensionsStringARB>("wglGetExtensionsStringARB");
			MakeContextCurrentARB=GetProcAddress<wglMakeContextCurrentARB>("wglMakeContextCurrentARB");
			GetCurrentReadDCARB=GetProcAddress<wglGetCurrentReadDCARB>("wglGetCurrentReadDCARB");
			CreateBufferRegionARB=GetProcAddress<wglCreateBufferRegionARB>("wglCreateBufferRegionARB");
			DeleteBufferRegionARB=GetProcAddress<wglDeleteBufferRegionARB>("wglDeleteBufferRegionARB");
			SaveBufferRegionARB=GetProcAddress<wglSaveBufferRegionARB>("wglSaveBufferRegionARB");
			RestoreBufferRegionARB=GetProcAddress<wglRestoreBufferRegionARB>("wglRestoreBufferRegionARB");
			GetPixelFormatAttribivARB_out=GetProcAddress<wglGetPixelFormatAttribivARB_out>("wglGetPixelFormatAttribivARB");
			GetPixelFormatAttribivARB_array=GetProcAddress<wglGetPixelFormatAttribivARB_array>("wglGetPixelFormatAttribivARB");
			GetPixelFormatAttribfvARB_out=GetProcAddress<wglGetPixelFormatAttribfvARB_out>("wglGetPixelFormatAttribfvARB");
			GetPixelFormatAttribfvARB_array=GetProcAddress<wglGetPixelFormatAttribfvARB_array>("wglGetPixelFormatAttribfvARB");
			ChoosePixelFormatARB_out=GetProcAddress<wglChoosePixelFormatARB_out>("wglChoosePixelFormatARB");
			ChoosePixelFormatARB_array=GetProcAddress<wglChoosePixelFormatARB_array>("wglChoosePixelFormatARB");
			_CreatePbufferARB=GetProcAddress<wglCreatePbufferARB>("wglCreatePbufferARB");
			GetPbufferDCARB=GetProcAddress<wglGetPbufferDCARB>("wglGetPbufferDCARB");
			ReleasePbufferDCARB=GetProcAddress<wglReleasePbufferDCARB>("wglReleasePbufferDCARB");
			DestroyPbufferARB=GetProcAddress<wglDestroyPbufferARB>("wglDestroyPbufferARB");
			_QueryPbufferARB=GetProcAddress<wglQueryPbufferARB>("wglQueryPbufferARB");
			_SetPbufferAttribARB=GetProcAddress<wglSetPbufferAttribARB>("wglSetPbufferAttribARB");
			BindTexImageARB=GetProcAddress<wglBindTexImageARB>("wglBindTexImageARB");
			ReleaseTexImageARB=GetProcAddress<wglReleaseTexImageARB>("wglReleaseTexImageARB");

			// Some extension functions
			GetSwapIntervalEXT=GetProcAddress<wglGetSwapIntervalEXT>("wglGetSwapIntervalEXT");
			SwapIntervalEXT=GetProcAddress<wglSwapIntervalEXT>("wglSwapIntervalEXT");
			CopyImageSubDataNV=GetProcAddress<wglCopyImageSubDataNV>("wglCopyImageSubDataNV");

			return _CreateContextAttribsARB!=null&&MakeContextCurrentARB!=null&&ChoosePixelFormatARB_out!=null&&GetPixelFormatAttribivARB_out!=null;
		}
	}
}
