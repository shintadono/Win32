using System;

namespace Win32.WGL
{
	/// <summary>
	/// Specifies the properties of the layer plane. Used as type for <see cref="LayerPlaneDescriptor.dwFlags"/>.
	/// </summary>
	[Flags]
	public enum LPD : uint
	{
		/// <summary>
		/// The layer plane is double-buffered. A layer plane can be double-buffered even when the main plane is single-buffered and vice versa.
		/// </summary>
		DOUBLEBUFFER=0x00000001,

		/// <summary>
		/// The layer plane is stereoscopic. A layer plane can be stereoscopic even when the main plane is monoscopic and vice versa.
		/// </summary>
		STEREO=0x00000002,

		/// <summary>
		/// The layer plane supports GDI drawing. The current implementation of OpenGL doesn't support this flag.
		/// </summary>
		SUPPORT_GDI=0x00000010,

		/// <summary>
		/// The layer plane supports OpenGL drawing.
		/// </summary>
		SUPPORT_OPENGL=0x00000020,

		/// <summary>
		/// The layer plane shares the depth buffer with the main plane.
		/// </summary>
		SHARE_DEPTH=0x00000040,

		/// <summary>
		/// The layer plane shares the stencil buffer with the main plane.
		/// </summary>
		SHARE_STENCIL=0x00000080,

		/// <summary>
		/// The layer plane shares the accumulation buffer with the main plane.
		/// </summary>
		SHARE_ACCUM=0x00000100,

		/// <summary>
		/// In a double-buffered layer plane, swapping the color buffer exchanges the front buffer and back buffer contents. The back buffer
		/// then contains the contents of the front buffer before the swap. This flag is a hint only and might not be provided by a driver.
		/// </summary>
		SWAP_EXCHANGE=0x00000200,

		/// <summary>
		/// In a double-buffered layer plane, swapping the color buffer copies the back buffer contents to the front buffer. The swap does
		/// not affect the back buffer contents. This flag is a hint only and might not be provided by a driver.
		/// </summary>
		SWAP_COPY=0x00000400,

		/// <summary>
		/// The <see cref="LayerPlaneDescriptor.crTransparent">crTransparent</see> member of the <see cref="LayerPlaneDescriptor"/> structure
		/// contains a transparent color or index value that enables underlying layers to show through this layer.
		/// All layer planes, except the lowest-numbered underlay layer, have a transparent color or index.
		/// </summary>
		TRANSPARENT=0x00001000
	}
}
