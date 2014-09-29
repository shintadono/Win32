using HDC=System.IntPtr;
using HGLRC=System.IntPtr;

namespace Win32.WGL
{
	/// <summary>
	/// Values of <see cref="wglContextAttributeARB.CONTEXT_PROFILE_MASK_ARB"/> at <see cref="O:Win32.WGL.wgl.CreateContextAttribsARB">wgl.CreateContextAttribsARB</see>.
	/// </summary>
	public enum wglContextProfileMaskARB : int
	{
		/// <summary>
		/// Requests a core-profile.
		/// </summary>
		CONTEXT_CORE_PROFILE_BIT_ARB=0x00000001,

		/// <summary>
		/// Requests a compalibility-profile.
		/// </summary>
		CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB=0x00000002,

		/// <summary>
		/// Requests a OpenGL ES compatible context.
		/// </summary>
		WGL_CONTEXT_ES_PROFILE_BIT_EXT=0x00000004,

		/// <summary>
		/// Requests a OpenGL ES compatible context.
		/// </summary>
		WGL_CONTEXT_ES2_PROFILE_BIT_EXT=0x00000004,
	}
}
