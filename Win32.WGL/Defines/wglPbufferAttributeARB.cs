namespace Win32.WGL
{
	/// <summary>
	/// Specifies attributes which can be used to create pbuffers, and to set or query attributes of/from pbuffers.
	/// </summary>
	public enum wglPbufferAttributeARB : int
	{
		#region WGL_ARB_pbuffer
		/// <summary>
		/// If set on pbuffer creation, a smaller pbuffer will be created, if the specified size is not possible.
		/// </summary>
		PBUFFER_LARGEST_ARB=0x2033,

		/// <summary>
		/// Query the width of the pbuffers.
		/// </summary>
		PBUFFER_WIDTH_ARB=0x2034,

		/// <summary>
		/// Query the height of the pbuffers.
		/// </summary>
		PBUFFER_HEIGHT_ARB=0x2035,

		/// <summary>
		/// Check if the pbuffer is lost.
		/// </summary>
		PBUFFER_LOST_ARB=0x2036,
		#endregion

		#region WGL_ARB_render_texture
		/// <summary>
		/// Specifies the texture format. Values of type <see cref="wglTextureFormatARB"/>.
		/// </summary>
		TEXTURE_FORMAT_ARB=0x2072,

		/// <summary>
		/// Specifies the texture target. Values of type <see cref="wglTextureTargetARB"/>.
		/// </summary>
		TEXTURE_TARGET_ARB=0x2073,

		/// <summary>
		/// Specifies that mipmap shall be supported and storage is allocated. Default is <b>false</b>.
		/// </summary>
		MIPMAP_TEXTURE_ARB=0x2074,

		/// <summary>
		/// Sets or queries the mipmap level which should be/is rendered to.
		/// </summary>
		MIPMAP_LEVEL_ARB=0x207B,

		/// <summary>
		/// Sets or queries the cube map face. Values of type <see cref="wglTextureCubeMapFaceARB"/>.
		/// </summary>
		CUBE_MAP_FACE_ARB=0x207C,
		#endregion

		#region WGL_NV_render_depth_texture
		/// <summary>
		/// Specifies the depth texture format. Values of type <see cref="wglDepthTextureFormatNV"/>.
		/// </summary>
		DEPTH_TEXTURE_FORMAT_NV=0x20A5,
		#endregion
	}
}
