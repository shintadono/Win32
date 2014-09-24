namespace Win32.WGL
{
	/// <summary>
	/// Tri-state for setting up OpenGL contexts.
	/// </summary>
	public enum DontCareBool
	{
		/// <summary>
		/// Force feature to be false/disabled.
		/// </summary>
		FALSE=0,

		/// <summary>
		/// Force feature to be true/enabled.
		/// </summary>
		TRUE=1,

		/// <summary>
		/// Don't care if feature is true/enabled or false/disabled.
		/// </summary>
		DONT_CARE=-1,
	}
}
