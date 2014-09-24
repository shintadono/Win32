using HDC=System.IntPtr;
using HGLRC=System.IntPtr;

namespace Win32.WGL
{
	/// <summary>
	/// Specifies the attributes available for context creation with <see cref="wgl.CreateContextAttribsARB(HDC, HGLRC, int[])">wgl.CreateContextAttribsARB</see>.
	/// </summary>
	public enum wglContextAttributeARB : int
	{
		#region WGL_ARB_create_context(-profile)
		/// <summary>
		/// Requests the major version. Default is 1.
		/// </summary>
		CONTEXT_MAJOR_VERSION_ARB=0x2091,

		/// <summary>
		/// Requests the minor version. Default is 0.
		/// </summary>
		CONTEXT_MINOR_VERSION_ARB=0x2092,

		/// <summary>
		/// Specifies the layer plane that the rendering context is to be bound to. See <see cref="wgl.CreateLayerContext"/>.
		/// </summary>
		CONTEXT_LAYER_PLANE_ARB=0x2093,

		/// <summary>
		/// Requests context abilities, see <see cref="wglContextFlagsARB"/>. Default is 0.
		/// </summary>
		CONTEXT_FLAGS_ARB=0x2094,

		/// <summary>
		/// Requests the profile (core or compatibility). Default is <see cref="wglContextProfileMaskARB.CONTEXT_CORE_PROFILE_BIT_ARB"/>.
		/// </summary>
		CONTEXT_PROFILE_MASK_ARB=0x9126,
		#endregion

		#region WGL_ARB_create_context_robustness
		/// <summary>
		/// Set the reset notification strategy for the rendering context. Default is <see cref="wglContextResetNotificationStrategyARB.NO_RESET_NOTIFICATION_ARB"/>.
		/// </summary>
		CONTEXT_RESET_NOTIFICATION_STRATEGY_ARB=0x8256,
		#endregion

		#region WGL_ARB_context_flush_control
		/// <summary>
		/// Requests the context release behaviour. Default is <see cref="wglContextReleaseBehaviour.FLUSH_ARB"/>. (Available since OpenGL 4.5.)
		/// </summary>
		CONTEXT_RELEASE_BEHAVIOR_ARB=0x2097,
		#endregion
	}
}
