using System;

namespace Win32
{
	/// <summary>
	/// Flags for describing a pixel format.
	/// </summary>
	[Flags]
	public enum PFD : uint
	{
		/// <summary>
		/// The buffer is double-buffered. This flag and <see cref="SUPPORT_GDI"/>
		/// are mutually exclusive in the current generic implementation.
		/// </summary>
		DOUBLEBUFFER=0x00000001,

		/// <summary>
		/// The buffer is stereoscopic. This flag is not supported in the current generic implementation.
		/// </summary>
		STEREO=0x00000002,

		/// <summary>
		/// The buffer can draw to a window or device surface.
		/// </summary>
		DRAW_TO_WINDOW=0x00000004,

		/// <summary>
		/// The buffer can draw to a memory bitmap.
		/// </summary>
		DRAW_TO_BITMAP=0x00000008,

		/// <summary>
		/// The buffer supports GDI drawing. This flag and <see cref="DOUBLEBUFFER"/>
		/// are mutually exclusive in the current generic implementation.
		/// </summary>
		SUPPORT_GDI=0x00000010,

		/// <summary>
		/// The buffer supports OpenGL drawing.
		/// </summary>
		SUPPORT_OPENGL=0x00000020,

		/// <summary>
		/// The pixel format is supported by the GDI software implementation, which is
		/// also known as the generic implementation. If this bit is clear, the pixel
		/// format is supported by a device driver or hardware.
		/// </summary>
		GENERIC_FORMAT=0x00000040,

		/// <summary>
		/// The buffer uses RGBA pixels on a palette-managed device.
		/// </summary>
		NEED_PALETTE=0x00000080,

		/// <summary>
		/// Defined in the pixel format descriptors of hardware that supports one hardware palette in 256-color mode only.
		/// </summary>
		NEED_SYSTEM_PALETTE=0x00000100,

		/// <summary>
		/// Swapping the color buffers causes the exchange of the back buffer's content with the front buffer's content.
		/// </summary>
		SWAP_EXCHANGE=0x00000200,

		/// <summary>
		/// Swapping the color buffers causes the content of the back buffer to be copied to the front buffer.
		/// </summary>
		SWAP_COPY=0x00000400,

		/// <summary>
		/// Indicates whether a device can swap individual layer planes with pixel formats that
		/// include double-buffered overlay or underlay planes. Otherwise all layer planes are
		/// swapped together as a group.
		/// </summary>
		SWAP_LAYER_BUFFERS=0x00000800,

		/// <summary>
		/// The pixel format is supported by a device driver that accelerates the generic implementation (MCD).
		/// If this flag is clear and the <see cref="GENERIC_FORMAT"/> flag is set, the pixel format is
		/// supported by the generic implementation only.
		/// </summary>
		GENERIC_ACCELERATED=0x00001000,

		/// <summary>
		/// The pixel buffer supports DirectDraw drawing, which allows applications
		/// to have low-level control of the output drawing surface.
		/// </summary>
		SUPPORT_DIRECTDRAW=0x00002000,

		/// <summary>
		/// The pixel buffer supports Direct3D drawing, which accellerated rendering
		/// in three dimensions.
		/// </summary>
		DIRECT3D_ACCELERATED=0x00004000,

		/// <summary>
		/// The pixel buffer supports compositing, which indicates that source pixels
		/// MAY overwrite or be combined with background pixels.
		/// </summary>
		SUPPORT_COMPOSITION=0x00008000,

		/// <summary>
		/// The requested pixel format can either have or not have a depth buffer. Only used in <see cref="DeviceContext.ChoosePixelFormat"/>.
		/// </summary>
		DEPTH_DONTCARE=0x20000000,

		/// <summary>
		/// The requested pixel format can be either single- or double-buffered. Only used in <see cref="DeviceContext.ChoosePixelFormat"/>.
		/// </summary>
		DOUBLEBUFFER_DONTCARE=0x40000000,

		/// <summary>
		/// The requested pixel format can be either monoscopic or stereoscopic. Only used in <see cref="DeviceContext.ChoosePixelFormat"/>.
		/// </summary>
		STEREO_DONTCARE=0x80000000,

		/// <summary>
		/// Combination of <see cref="DRAW_TO_WINDOW"/>, <see cref="SUPPORT_OPENGL"/>, <see cref="DOUBLEBUFFER"/> and <see cref="SUPPORT_COMPOSITION"/>.
		/// </summary>
		Default=DRAW_TO_WINDOW|SUPPORT_OPENGL|DOUBLEBUFFER|SUPPORT_COMPOSITION,
	}
}
