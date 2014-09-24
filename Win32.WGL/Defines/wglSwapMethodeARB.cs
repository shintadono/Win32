namespace Win32.WGL
{
	/// <summary>
	/// Specifies swap methodes.
	/// </summary>
	public enum wglSwapMethodeARB : int
	{
		/// <summary>
		/// Front and back buffer will be exchanged.
		/// </summary>
		EXCHANGE_ARB=0x2028,

		/// <summary>
		/// Back buffer will be copied to front.
		/// </summary>
		COPY_ARB=0x2029,

		/// <summary>
		/// Double buffering is not supported.
		/// </summary>
		UNDEFINED_ARB=0x202A,
	}
}
