namespace Win32
{
	/// <summary>
	/// For display devices only, the orientation at which images should be presented.
	/// </summary>
	public enum DMDO : uint
	{
		/// <summary>
		/// The display orientation is the natural orientation of the display device; it should be used as the default.
		/// </summary>
		DEFAULT=0,

		/// <summary>
		/// The display orientation is rotated 90 degrees (measured clockwise) from <see cref="DMDO.DEFAULT"/>.
		/// </summary>
		_90=1,

		/// <summary>
		/// The display orientation is rotated 180 degrees (measured clockwise) from <see cref="DMDO.DEFAULT"/>.
		/// </summary>
		_180=2,

		/// <summary>
		/// The display orientation is rotated 270 degrees (measured clockwise) from <see cref="DMDO.DEFAULT"/>.
		/// </summary>
		_270=3,
	}
}
