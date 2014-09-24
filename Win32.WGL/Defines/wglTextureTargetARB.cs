namespace Win32.WGL
{
	/// <summary>
	/// Specifies the texture target. Used as value for <see cref="wglPbufferAttributeARB.TEXTURE_TARGET_ARB"/>
	/// </summary>
	public enum wglTextureTargetARB : int
	{
		/// <summary>
		/// Cube map texture.
		/// </summary>
		TEXTURE_CUBE_MAP_ARB=0x2078,

		/// <summary>
		/// 1D texture.
		/// </summary>
		TEXTURE_1D_ARB=0x2079,

		/// <summary>
		/// 2D texture.
		/// </summary>
		TEXTURE_2D_ARB=0x207A,

		/// <summary>
		/// No texture.
		/// </summary>
		NO_TEXTURE_ARB=0x2077,

		#region WGL_NV_render_texture_rectangle
		/// <summary>
		/// Rectangle texture.
		/// </summary>
		TEXTURE_RECTANGLE_NV=0x20A2,
		#endregion
	}
}
