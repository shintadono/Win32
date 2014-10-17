using System;
using System.Runtime.InteropServices;

namespace Win32
{
	/// <summary>
	/// Describes the pixel format of a drawing surface.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct PixelFormatDescriptor
	{
		/// <summary>
		/// Specifies the size of this data structure. This value should be set to <c>Marshal.Sizeof(new PixelFormatDescriptor())</c>.
		/// </summary>
		public ushort nSize;

		/// <summary>
		/// Specifies the version of this data structure. This value should be set to 1.
		/// </summary>
		public ushort nVersion;

		/// <summary>
		/// Specifies the pixel format flags. See <see cref="PFD"/> for more informations.
		/// </summary>
		public PFD dwFlags;

		/// <summary>
		/// Specifies the pixel type. See <see cref="PFD_TYPE"/> for more informations.
		/// </summary>
		public PFD_TYPE iPixelType;

		/// <summary>
		/// Specifies the number of color bitplanes in each color buffer. For RGBA pixel types, it is
		/// the size of the color buffer, excluding the alpha bitplanes. For color-index pixels, it is
		/// the size of the color-index buffer.
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
		/// Specifies the number of alpha bitplanes in each RGBA color buffer. Alpha bitplanes are not supported.
		/// </summary>
		public byte cAlphaBits;

		/// <summary>
		/// Specifies the shift count for alpha bitplanes in each RGBA color buffer. Alpha bitplanes are not supported.
		/// </summary>
		public byte cAlphaShift;

		/// <summary>
		/// Specifies the total number of bitplanes in the accumulation buffer.
		/// </summary>
		[Obsolete("Accumulation buffers aren't supported in the OpenGL core profile anymore.")]
		public byte cAccumBits;

		/// <summary>
		/// Specifies the number of red bitplanes in the accumulation buffer.
		/// </summary>
		[Obsolete("Accumulation buffers aren't supported in the OpenGL core profile anymore.")]
		public byte cAccumRedBits;

		/// <summary>
		/// Specifies the number of green bitplanes in the accumulation buffer.
		/// </summary>
		[Obsolete("Accumulation buffers aren't supported in the OpenGL core profile anymore.")]
		public byte cAccumGreenBits;

		/// <summary>
		/// Specifies the number of blue bitplanes in the accumulation buffer.
		/// </summary>
		[Obsolete("Accumulation buffers aren't supported in the OpenGL core profile anymore.")]
		public byte cAccumBlueBits;

		/// <summary>
		/// Specifies the number of alpha bitplanes in the accumulation buffer.
		/// </summary>
		[Obsolete("Accumulation buffers aren't supported in the OpenGL core profile anymore.")]
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
		/// Specifies the number of auxiliary buffers. Auxiliary buffers are not supported.
		/// </summary>
		public byte cAuxBuffers;

		/// <summary>
		/// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.
		/// </summary>
		public byte iLayerType;

		/// <summary>
		/// Specifies the number of overlay and underlay planes. Bits 0 through 3 specify up to
		/// 15 overlay planes and bits 4 through 7 specify up to 15 underlay planes.
		/// </summary>
		public byte bReserved;

		/// <summary>
		/// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.
		/// </summary>
		public uint dwLayerMask;

		/// <summary>
		/// Specifies the transparent color or index of an underlay plane. When the pixel type is
		/// RGBA, <b>dwVisibleMask</b> is a transparent RGB color value. When the pixel type is color
		/// index, it is a transparent index value.
		/// </summary>
		public uint dwVisibleMask;

		/// <summary>
		/// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.
		/// </summary>
		public uint dwDamageMask;

		/// <summary>
		/// Initializes the structure.
		/// </summary>
		/// <param name="flags">A <see cref="PFD"/>-bitmask specifying pixel format flags.</param>
		public PixelFormatDescriptor(PFD flags=PFD.Default)
		{
			nSize=0;
			nVersion=1;
			dwFlags=flags;
			iPixelType=PFD_TYPE.RGBA;
			cColorBits=32;
			cRedBits=cRedShift=cGreenBits=cGreenShift=cBlueBits=cBlueShift=cAlphaBits=cAlphaShift=0;
#pragma warning disable 618 // Disable deprecated messages
			cAccumBits=cAccumRedBits=cAccumGreenBits=cAccumBlueBits=cAccumAlphaBits=0;
#pragma warning restore 618
			cDepthBits=24;
			cStencilBits=8;
			cAuxBuffers=iLayerType=bReserved=0;
			dwLayerMask=dwVisibleMask=dwDamageMask=0;

			nSize=(ushort)Marshal.SizeOf(this);
		}
	}
}
