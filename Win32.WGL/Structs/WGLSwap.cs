using HDC=System.IntPtr;

namespace Win32.WGL
{
	/// <summary>
	/// Structure for specifying for (layered) buffer swap operations.
	/// </summary>
	public struct WGLSwap
	{
		/// <summary>
		/// The handle to the device context.
		/// </summary>
		public HDC hdc;

		/// <summary>
		/// <see cref="WGL_SWAP"/>-bitmask specifying the planes to be swapped.
		/// </summary>
		public WGL_SWAP uiFlags;
	}
}
