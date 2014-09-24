namespace Win32.WGL
{
	/// <summary>
	/// Values for <see cref="wglContextAttributeARB.CONTEXT_RELEASE_BEHAVIOR_ARB"/>.
	/// </summary>
	public enum wglContextReleaseBehaviour : int
	{
		/// <summary>
		/// No flush on context release.
		/// </summary>
		NONE_ARB=0x0000,

		/// <summary>
		/// Implicit flush all pending commands of the context before releasing it.
		/// </summary>
		FLUSH_ARB=0x2098,
	}
}
