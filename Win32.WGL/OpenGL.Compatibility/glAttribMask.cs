using System;

namespace OpenGL.Compatibility
{
	/// <summary>
	/// Specifies a mask that indicates which attributes to save in push and pop operations to the server attribute stack.
	/// </summary>
	[Obsolete("Stashing of context attributes is not supported in the OpenGL core profile anymore.")]
	[Flags]
	public enum glAttribMask : uint
	{
		/// <summary>
		/// Current RGBA color/color index, normal vector, texture coordinates, raster position, edge flag,...
		/// </summary>
		CURRENT_BIT=0x00000001,

		/// <summary>
		/// Point size, smooth flag,...
		/// </summary>
		POINT_BIT=0x00000002,

		/// <summary>
		/// Line size, stipple pattern, smooth flag,...
		/// </summary>
		LINE_BIT=0x00000004,

		/// <summary>
		/// Polygon mode, cull face mode, front face mode, smooth flag,...
		/// </summary>
		POLYGON_BIT=0x00000008,

		/// <summary>
		/// Polygon stipple image.
		/// </summary>
		POLYGON_STIPPLE_BIT=0x00000010,

		/// <summary>
		/// Read buffer, color biases, color scales, color mapping,...
		/// </summary>
		PIXEL_MODE_BIT=0x00000020,

		/// <summary>
		/// Ambient, diffuse, and specular intensity for each light, ambient, diffuse, specular, and emissive color for each material, shading model...
		/// </summary>
		LIGHTING_BIT=0x00000040,

		/// <summary>
		/// Fog color, density, mode,...
		/// </summary>
		FOG_BIT=0x00000080,

		/// <summary>
		/// Depth test, depth buffer clear value, test functionm,...
		/// </summary>
		DEPTH_BUFFER_BIT=0x00000100,

		/// <summary>
		/// Accumulation buffer clear value.
		/// </summary>
		ACCUM_BUFFER_BIT=0x00000200,

		/// <summary>
		/// Stencil buffer clear value, stencil mask, stencil function,...
		/// </summary>
		STENCIL_BUFFER_BIT=0x00000400,

		/// <summary>
		/// Depth range (near and far), viewport origin and extent.
		/// </summary>
		VIEWPORT_BIT=0x00000800,

		/// <summary>
		/// Matrix mode, clipping planes, normalize flag,...
		/// </summary>
		TRANSFORM_BIT=0x00001000,

		/// <summary>
		/// State of all capabilities.
		/// </summary>
		ENABLE_BIT=0x00002000,

		/// <summary>
		/// color mode, blend value, blend function, dither flag,...
		/// </summary>
		COLOR_BUFFER_BIT=0x00004000,

		/// <summary>
		/// State of all hints.
		/// </summary>
		HINT_BIT=0x00008000,

		/// <summary>
		/// 1D and 2D grid endpoints and divisions, auto normal flag,...
		/// </summary>
		EVAL_BIT=0x00010000,

		/// <summary>
		/// List base setting.
		/// </summary>
		LIST_BIT=0x00020000,

		/// <summary>
		/// Minification function, magnification function, texture coordinate wrap mode, border color,...
		/// </summary>
		TEXTURE_BIT=0x00040000,

		/// <summary>
		/// Scissor box.
		/// </summary>
		SCISSOR_BIT=0x00080000,

		/// <summary>
		/// Sample coverage flags and values.
		/// </summary>
		MULTISAMPLE_BIT=0x20000000,

		/// <summary>
		/// All bits.
		/// </summary>
		ALL_ATTRIB_BITS=0xFFFFFFFF,
	}
}
