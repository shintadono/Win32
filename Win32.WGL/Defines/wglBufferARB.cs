namespace Win32.WGL
{
	/// <summary>
	/// Specifies a color buffer. Used be <see cref="wgl.BindTexImageARB"/> and <see cref="wgl.ReleaseTexImageARB"/>.
	/// </summary>
	public enum wglBufferARB : int
	{
		/// <summary>
		/// Front left.
		/// </summary>
		FRONT_LEFT_ARB=0x2083,

		/// <summary>
		/// Front right.
		/// </summary>
		FRONT_RIGHT_ARB=0x2084,

		/// <summary>
		/// Back left.
		/// </summary>
		BACK_LEFT_ARB=0x2085,

		/// <summary>
		/// back right.
		/// </summary>
		BACK_RIGHT_ARB=0x2086,

		/// <summary>
		/// Auxilary buffer 0.
		/// </summary>
		AUX0_ARB=0x2087,

		/// <summary>
		/// Auxilary buffer 1.
		/// </summary>
		AUX1_ARB=0x2088,

		/// <summary>
		/// Auxilary buffer 2.
		/// </summary>
		AUX2_ARB=0x2089,

		/// <summary>
		/// Auxilary buffer 3.
		/// </summary>
		AUX3_ARB=0x208A,

		/// <summary>
		/// Auxilary buffer 4.
		/// </summary>
		AUX4_ARB=0x208B,

		/// <summary>
		/// Auxilary buffer 5.
		/// </summary>
		AUX5_ARB=0x208C,

		/// <summary>
		/// Auxilary buffer 6.
		/// </summary>
		AUX6_ARB=0x208D,

		/// <summary>
		/// Auxilary buffer 7.
		/// </summary>
		AUX7_ARB=0x208E,

		/// <summary>
		/// Auxilary buffer 8.
		/// </summary>
		AUX8_ARB=0x208F,

		/// <summary>
		/// Auxilary buffer 9.
		/// </summary>
		AUX9_ARB=0x2090,

		#region WGL_NV_render_depth_texture
		/// <summary>
		/// Depth buffer.
		/// </summary>
		DEPTH_COMPONENT_NV=0x20A7,
		#endregion
	}
}
