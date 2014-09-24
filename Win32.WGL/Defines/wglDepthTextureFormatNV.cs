namespace Win32.WGL
{
	/// <summary>
	/// Specifies the depth texture format. Used as value for <see cref="wglPbufferAttributeARB.DEPTH_TEXTURE_FORMAT_NV"/>
	/// </summary>
	public enum wglDepthTextureFormatNV : int
	{
		/// <summary>
		/// Depth texture.
		/// </summary>
		TEXTURE_DEPTH_COMPONENT_NV=0x20A6,

		/// <summary>
		/// No texture.
		/// </summary>
		NO_TEXTURE_ARB=0x2077,
	}
}
