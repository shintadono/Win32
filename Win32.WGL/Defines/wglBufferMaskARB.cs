using System;

namespace Win32.WGL
{
	/// <summary>
	/// Defines buffers.
	/// </summary>
	[Flags]
	public enum wglBufferMaskARB : uint
	{
		/// <summary>
		/// Front color buffer.
		/// </summary>
		FRONT_COLOR_BUFFER_BIT_ARB=0x00000001,

		/// <summary>
		/// Back color buffer.
		/// </summary>
		BACK_COLOR_BUFFER_BIT_ARB=0x00000002,

		/// <summary>
		/// Depth buffer.
		/// </summary>
		DEPTH_BUFFER_BIT_ARB=0x00000004,

		/// <summary>
		/// Stencil buffer.
		/// </summary>
		STENCIL_BUFFER_BIT_ARB=0x00000008,
	}
}
