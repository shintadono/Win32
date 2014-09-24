namespace Win32
{
	/// <summary>
	/// Specifies the type of media being printed on.
	/// </summary>
	public enum DMMEDIA : uint
	{
		/// <summary>
		/// Plain paper.
		/// </summary>
		STANDARD=1,

		/// <summary>
		/// Transparent film.
		/// </summary>
		TRANSPARENCY=2,

		/// <summary>
		/// Glossy paper.
		/// </summary>
		GLOSSY=3,

		/// <summary>
		/// Start of the user-defined media types.
		/// </summary>
		USER=256,
	}
}
