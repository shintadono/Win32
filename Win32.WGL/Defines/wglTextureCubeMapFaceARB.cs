namespace Win32.WGL
{
	/// <summary>
	/// Specifies the cube map faces. Used as value for <see cref="wglPbufferAttributeARB.CUBE_MAP_FACE_ARB"/>.
	/// </summary>
	public enum wglTextureCubeMapFaceARB : int
	{
		/// <summary>
		/// Positive X.
		/// </summary>
		POSITIVE_X_ARB=0x207D,

		/// <summary>
		/// Negative X.
		/// </summary>
		NEGATIVE_X_ARB=0x207E,

		/// <summary>
		/// Positive Y.
		/// </summary>
		POSITIVE_Y_ARB=0x207F,

		/// <summary>
		/// Negative Y.
		/// </summary>
		NEGATIVE_Y_ARB=0x2080,

		/// <summary>
		/// Positive Z.
		/// </summary>
		POSITIVE_Z_ARB=0x2081,

		/// <summary>
		/// Negative Z.
		/// </summary>
		NEGATIVE_Z_ARB=0x2082,
	}
}
