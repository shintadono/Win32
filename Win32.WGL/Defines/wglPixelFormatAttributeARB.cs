using HDC=System.IntPtr;

namespace Win32.WGL
{
	/// <summary>
	/// Specifies attributes for pixel formats. Used by <see cref="wgl.ChoosePixelFormatARB(HDC, int[], float[], int[], out uint)">wgl.ChoosePixelFormatARB</see> and
	/// <see cref="wgl.GetPixelFormatAttribivARB(HDC, int, int, wglPixelFormatAttributeARB[], int[])">wgl.GetPixelFormatAttribivARB</see>.
	/// </summary>
	public enum wglPixelFormatAttributeARB : int
	{
		#region WGL_ARB_pixel_format
		/// <summary>
		/// The number of pixel formats for the device context.
		/// </summary>
		NUMBER_PIXEL_FORMATS_ARB=0x2000,

		/// <summary>
		/// <b>true</b> if the pixel format can be used with a window.
		/// </summary>
		DRAW_TO_WINDOW_ARB=0x2001,

		/// <summary>
		/// <b>true</b> if the pixel format can be used with a memory bitmap.
		/// </summary>
		DRAW_TO_BITMAP_ARB=0x2002,

		/// <summary>
		/// A <see cref="wglAccelerationModeARB"/> indicating whether the pixel format is supported by the driver.
		/// </summary>
		ACCELERATION_ARB=0x2003,

		/// <summary>
		/// A logical palette is required to achieve the best results for this pixel format. Paletted colors are not supported in OpenGL core profile.
		/// </summary>
		NEED_PALETTE_ARB=0x2004,

		/// <summary>
		/// The hardware supports one hardware palette in 256-color mode only. Paletted colors are not supported in OpenGL core profile.
		/// </summary>
		NEED_SYSTEM_PALETTE_ARB=0x2005,

		/// <summary>
		/// <b>true</b> if the pixel format supports swapping layer planes independently of the main planes.
		/// </summary>
		SWAP_LAYER_BUFFERS_ARB=0x2006,

		/// <summary>
		/// A <see cref="wglSwapMethodeARB"/> indicating how back and front buffer are swapped.
		/// </summary>
		SWAP_METHOD_ARB=0x2007,

		/// <summary>
		/// The number of overlay planes.
		/// </summary>
		NUMBER_OVERLAYS_ARB=0x2008,

		/// <summary>
		/// The number of underlay planes.
		/// </summary>
		NUMBER_UNDERLAYS_ARB=0x2009,

		/// <summary>
		/// <b>true</b> if transparency is supported.
		/// </summary>
		TRANSPARENT_ARB=0x200A,

		/// <summary>
		/// The transparent red color value.
		/// </summary>
		TRANSPARENT_RED_VALUE_ARB=0x2037,

		/// <summary>
		/// The transparent green color value.
		/// </summary>
		TRANSPARENT_GREEN_VALUE_ARB=0x2038,

		/// <summary>
		/// The transparent blue color value.
		/// </summary>
		TRANSPARENT_BLUE_VALUE_ARB=0x2039,

		/// <summary>
		/// The transparent alpha color value.
		/// </summary>
		TRANSPARENT_ALPHA_VALUE_ARB=0x203A,

		/// <summary>
		/// The transparent color index value.
		/// </summary>
		TRANSPARENT_INDEX_VALUE_ARB=0x203B,

		/// <summary>
		/// <b>true</b> if the layer plane shares the depth buffer with the main planes.
		/// </summary>
		SHARE_DEPTH_ARB=0x200C,

		/// <summary>
		/// <b>true</b> if the layer plane shares the stencil buffer with the main planes.
		/// </summary>
		SHARE_STENCIL_ARB=0x200D,

		/// <summary>
		/// <b>true</b> if the layer plane shares the accumulation buffer with the main planes. Accumulation buffer are not supported in OpenGL core profile.
		/// </summary>
		SHARE_ACCUM_ARB=0x200E,

		/// <summary>
		/// <b>true</b> if GDI rendering is supported. GDI rendering does not support the OpenGL core profile.
		/// </summary>
		SUPPORT_GDI_ARB=0x200F,

		/// <summary>
		/// <b>true</b> if OpenGL is supported.
		/// </summary>
		SUPPORT_OPENGL_ARB=0x2010,

		/// <summary>
		/// <b>true</b> if the color buffer has back/front pairs.
		/// </summary>
		DOUBLE_BUFFER_ARB=0x2011,

		/// <summary>
		/// <b>true</b> if the color buffer has left/right pairs.
		/// </summary>
		STEREO_ARB=0x2012,

		/// <summary>
		/// A <see cref="wglPixelTypeARB"/> specifying the type of pixel data.
		/// </summary>
		PIXEL_TYPE_ARB=0x2013,

		/// <summary>
		/// The number of color bitplanes in each color buffer.
		/// </summary>
		COLOR_BITS_ARB=0x2014,

		/// <summary>
		/// The number of red bitplanes in each RGBA color buffer.
		/// </summary>
		RED_BITS_ARB=0x2015,

		/// <summary>
		/// The shift count for red bitplanes in each RGBA color buffer.
		/// </summary>
		RED_SHIFT_ARB=0x2016,

		/// <summary>
		/// The number of green bitplanes in each RGBA color buffer.
		/// </summary>
		GREEN_BITS_ARB=0x2017,

		/// <summary>
		/// The shift count for green bitplanes in each RGBA color buffer.
		/// </summary>
		GREEN_SHIFT_ARB=0x2018,

		/// <summary>
		/// The number of blue bitplanes in each RGBA color buffer.
		/// </summary>
		BLUE_BITS_ARB=0x2019,

		/// <summary>
		/// The shift count for blue bitplanes in each RGBA color buffer.
		/// </summary>
		BLUE_SHIFT_ARB=0x201A,

		/// <summary>
		/// The number of alpha bitplanes in each RGBA color buffer.
		/// </summary>
		ALPHA_BITS_ARB=0x201B,

		/// <summary>
		/// The shift count for alpha bitplanes in each RGBA color buffer.
		/// </summary>
		ALPHA_SHIFT_ARB=0x201C,

		/// <summary>
		/// The total number of bitplanes in the accumulation buffer. Accumulation buffer are not supported in OpenGL core profile.
		/// </summary>
		ACCUM_BITS_ARB=0x201D,

		/// <summary>
		/// The number of red bitplanes in the accumulation buffer. Accumulation buffer are not supported in OpenGL core profile.
		/// </summary>
		ACCUM_RED_BITS_ARB=0x201E,

		/// <summary>
		/// The number of green bitplanes in the accumulation buffer. Accumulation buffer are not supported in OpenGL core profile.
		/// </summary>
		ACCUM_GREEN_BITS_ARB=0x201F,

		/// <summary>
		/// The number of blue bitplanes in the accumulation buffer. Accumulation buffer are not supported in OpenGL core profile.
		/// </summary>
		ACCUM_BLUE_BITS_ARB=0x2020,

		/// <summary>
		/// The number of alpha bitplanes in the accumulation buffer. Accumulation buffer are not supported in OpenGL core profile.
		/// </summary>
		ACCUM_ALPHA_BITS_ARB=0x2021,

		/// <summary>
		/// The depth of the depth buffer.
		/// </summary>
		DEPTH_BITS_ARB=0x2022,

		/// <summary>
		/// The depth of the stencil buffer.
		/// </summary>
		STENCIL_BITS_ARB=0x2023,

		/// <summary>
		/// The number of auxiliary buffers. Auxiliary buffers are not supported in OpenGL core profile.
		/// </summary>
		AUX_BUFFERS_ARB=0x2024,
		#endregion

		#region WGL_ARB_pbuffer
		/// <summary>
		/// <b>true</b> if the pixel format supports pbuffers
		/// </summary>
		DRAW_TO_PBUFFER_ARB=0x202D,

		/// <summary>
		/// The maximum pixels in a pbuffer.
		/// </summary>
		MAX_PBUFFER_PIXELS_ARB=0x202E,

		/// <summary>
		/// The maximum pixels width of a pbuffer in pixels.
		/// </summary>
		MAX_PBUFFER_WIDTH_ARB=0x202F,

		/// <summary>
		/// The maximum pixels height of a pbuffer in pixels.
		/// </summary>
		MAX_PBUFFER_HEIGHT_ARB=0x2030,
		#endregion

		#region WGL_ARB_render_texture
		/// <summary>
		/// <b>true</b> if the color buffers can be bound to a RGB texture.
		/// </summary>
		BIND_TO_TEXTURE_RGB_ARB=0x2070,

		/// <summary>
		/// <b>true</b> if the color buffers can be bound to a RGBA texture.
		/// </summary>
		BIND_TO_TEXTURE_RGBA_ARB=0x2071,
		#endregion

		#region WGL_ARB_multisample
		/// <summary>
		/// The number of available multisample buffers. (Currently only 1 multisample buffer is supported. Zero is returned if no multisample buffer is available.)
		/// </summary>
		SAMPLE_BUFFERS_ARB=0x2041,

		/// <summary>
		/// The number of samples per pixel.
		/// </summary>
		SAMPLES_ARB=0x2042, // = WGL_COVERAGE_SAMPLES_NV
		#endregion

		#region WGL_ARB_framebuffer_sRGB
		/// <summary>
		/// <b>true</b> if the pixel format supports sRGB.
		/// </summary>
		FRAMEBUFFER_SRGB_CAPABLE_ARB=0x20A9,
		#endregion

		#region WGL_EXT_depth_float
		/// <summary>
		/// <b>true</b> if the pixel format supports floating point depth buffer.
		/// </summary>
		DEPTH_FLOAT_EXT=0x2040,
		#endregion

		#region WGL_NV_render_texture_rectangle
		/// <summary>
		/// <b>true</b> if the pixel format supports binding pbuffers as RGB texture rectangle.
		/// </summary>
		BIND_TO_TEXTURE_RECTANGLE_RGB_NV=0x20A0,

		/// <summary>
		/// <b>true</b> if the pixel format supports binding pbuffers as RGBA texture rectangle.
		/// </summary>
		BIND_TO_TEXTURE_RECTANGLE_RGBA_NV=0x20A1,
		#endregion

		#region WGL_NV_render_depth_texture
		/// <summary>
		/// <b>true</b> if the pixel format supports binding depth buffers as textures.
		/// </summary>
		BIND_TO_TEXTURE_DEPTH_NV=0x20A3,

		/// <summary>
		/// <b>true</b> if the pixel format supports binding depth buffers as texture rectangle.
		/// </summary>
		BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV=0x20A4,
		#endregion
	}
}
