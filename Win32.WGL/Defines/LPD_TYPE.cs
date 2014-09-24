using System;

namespace Win32.WGL
{
	/// <summary>
	/// Specifies the type of pixel data. Used as type for <see cref="LayerPlaneDescriptor.iPixelType"/>.
	/// </summary>
	public enum LPD_TYPE : byte
	{
		/// <summary>
		/// RGBA pixels. Each pixel has four components: red, green, blue, and alpha.
		/// </summary>
		RGBA=0,

		/// <summary>
		/// Color-index pixels. Each pixel uses a color-index value.
		/// </summary>
		[Obsolete("Palettes and indexed colors aren't supported in the OpenGL core profile anymore.")]
		COLORINDEX=1
	}
}
