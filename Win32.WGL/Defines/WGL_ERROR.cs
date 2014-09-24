namespace Win32.WGL
{
	/// <summary>
	/// Additional error codes (see <b>GetLastError()</b>) returned be wgl-functions.
	/// </summary>
	public enum WGL_ERROR
	{
		/// <summary>
		/// Pixel type don't match.
		/// </summary>
		INVALID_PIXEL_TYPE_ARB=0x2043,

		/// <summary>
		/// Device contexts are not compatible.
		/// </summary>
		INCOMPATIBLE_DEVICE_CONTEXTS_ARB=0x2054,

		/// <summary>
		/// Invalid version number.
		/// </summary>
		INVALID_VERSION_ARB=0x2095,

		/// <summary>
		/// Invalid profile name.
		/// </summary>
		INVALID_PROFILE_ARB=0x2096,
	}
}
