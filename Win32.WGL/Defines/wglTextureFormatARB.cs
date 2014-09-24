namespace Win32.WGL
{
	/// <summary>
	/// Specifies the texture format. Used as value for <see cref="wglPbufferAttributeARB.TEXTURE_FORMAT_ARB"/>
	/// </summary>
	public enum wglTextureFormatARB : int
	{
		/// <summary>
		/// RGB texture.
		/// </summary>
		TEXTURE_RGB_ARB=0x2075,

		/// <summary>
		/// RGBA texture.
		/// </summary>
		TEXTURE_RGBA_ARB=0x2076,

		/// <summary>
		/// No texture.
		/// </summary>
		NO_TEXTURE_ARB=0x2077,
	}
}
