using HDC=System.IntPtr;
using HGLRC=System.IntPtr;

namespace Win32.WGL
{
	/// <summary>
	/// Values of <see cref="wglContextAttributeARB.CONTEXT_RESET_NOTIFICATION_STRATEGY_ARB"/> at <see cref="O:Win32.WGL.wgl.CreateContextAttribsARB">wgl.CreateContextAttribsARB</see>.
	/// </summary>
	public enum wglContextResetNotificationStrategyARB : int
	{
		/// <summary>
		/// Loss of all context state on graphics resets, requiring the recreation of all associated objects.
		/// </summary>
		LOSE_CONTEXT_ON_RESET_ARB=0x8252,

		/// <summary>
		/// No notifications of reset events.
		/// </summary>
		NO_RESET_NOTIFICATION_ARB=0x8261,
	}
}
