using System;
using System.Runtime.InteropServices;

namespace Win32.WGL
{
	/// <summary>
	/// Describes the pixel format of a drawing surface.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct LayerPlaneDescriptor
	{
		/// <summary>
		/// Specifies the size of this data structure. Set this value to Marshal.SizeOf(new LayerPlaneDescriptor())=32.
		/// </summary>
		public ushort nSize;

		/// <summary>
		/// Specifies the version of this data structure. Set this value to 1.
		/// </summary>
		public ushort nVersion;

		/// <summary>
		/// A set of bit flags that specify properties of the layer plane.
		/// </summary>
		public LPD dwFlags;

		/// <summary>
		/// Specifies the type of pixel data.
		/// </summary>
		public LPD_TYPE iPixelType;

		/// <summary>
		/// Specifies the number of color bitplanes in each color buffer. For RGBA pixel types, it is the size of the color buffer,
		/// excluding the alpha bitplanes. For color-index pixels, it is the size of the color-index buffer.
		/// </summary>
		public byte cColorBits;

		/// <summary>
		/// Specifies the number of red bitplanes in each RGBA color buffer.
		/// </summary>
		public byte cRedBits;

		/// <summary>
		/// Specifies the shift count for red bitplanes in each RGBA color buffer.
		/// </summary>
		public byte cRedShift;

		/// <summary>
		/// Specifies the number of green bitplanes in each RGBA color buffer.
		/// </summary>
		public byte cGreenBits;

		/// <summary>
		/// Specifies the shift count for green bitplanes in each RGBA color buffer.
		/// </summary>
		public byte cGreenShift;

		/// <summary>
		/// Specifies the number of blue bitplanes in each RGBA color buffer.
		/// </summary>
		public byte cBlueBits;

		/// <summary>
		/// Specifies the shift count for blue bitplanes in each RGBA color buffer.
		/// </summary>
		public byte cBlueShift;

		/// <summary>
		/// Specifies the number of alpha bitplanes in each RGBA color buffer. Alpha bitplanes are not supported by the GDI.
		/// </summary>
		public byte cAlphaBits;

		/// <summary>
		/// Specifies the shift count for alpha bitplanes in each RGBA color buffer. Alpha bitplanes are not supported by the GDI.
		/// </summary>
		public byte cAlphaShift;

		/// <summary>
		/// Specifies the total number of bitplanes in the accumulation buffer.
		/// </summary>
		public byte cAccumBits;

		/// <summary>
		/// Specifies the number of red bitplanes in the accumulation buffer.
		/// </summary>
		public byte cAccumRedBits;

		/// <summary>
		/// Specifies the number of green bitplanes in the accumulation buffer.
		/// </summary>
		public byte cAccumGreenBits;

		/// <summary>
		/// Specifies the number of blue bitplanes in the accumulation buffer.
		/// </summary>
		public byte cAccumBlueBits;

		/// <summary>
		/// Specifies the number of alpha bitplanes in the accumulation buffer.
		/// </summary>
		public byte cAccumAlphaBits;

		/// <summary>
		/// Specifies the depth of the depth (z-axis) buffer.
		/// </summary>
		public byte cDepthBits;

		/// <summary>
		/// Specifies the depth of the stencil buffer.
		/// </summary>
		public byte cStencilBits;

		/// <summary>
		/// Specifies the number of auxiliary buffers. Auxiliary buffers are not supported by the GDI.
		/// </summary>
		public byte cAuxBuffers;

		/// <summary>
		/// Specifies the layer plane number. Positive number are overlay planes, negative numbers are underlay planes.
		/// </summary>
		public sbyte iLayerPlane;

		/// <summary>
		/// Not used. Must be zero.
		/// </summary>
		public byte bReserved;

		/// <summary>
		/// When the <see cref="LPD.TRANSPARENT"/> flag is set, specifies the transparent color or index value. Typically the value is zero.
		/// </summary>
		public uint crTransparent;
	}
}
