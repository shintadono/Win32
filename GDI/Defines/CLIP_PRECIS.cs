namespace Win32
{
	/// <summary>
	/// The clipping precision.
	/// </summary>
	public enum CLIP_PRECIS : uint
	{
		/// <summary>
		/// Specifies default clipping behavior.
		/// </summary>
		DEFAULT=0,

		/// <summary>
		/// Not used.
		/// </summary>
		CHARACTER=1,

		/// <summary>
		/// Not used by the font mapper, but is returned when raster, vector, or TrueType fonts are enumerated.
		/// </summary>
		STROKE=2,

		/// <summary>
		/// Not used.
		/// </summary>
		MASK=0xf,

		/// <summary>
		/// <para>When this value is used, the rotation for all fonts depends on whether the orientation of the coordinate system is left-handed or right-handed.</para>
		/// <para>If not used, device fonts always rotate counterclockwise, but the rotation of other fonts is dependent on the orientation of the coordinate system.</para>
		/// </summary>
		LH_ANGLES=(1<<4),

		/// <summary>
		/// Not used.
		/// </summary>
		TT_ALWAYS=(2<<4),

		/// <summary>
		/// Windows XP SP1: Turns off font association for the font. Note that this flag is not guaranteed to have any effect on any platform after Windows Server 2003.
		/// </summary>
		DFA_DISABLE=(4<<4),

		/// <summary>
		/// You must specify this flag to use an embedded read-only font.
		/// </summary>
		EMBEDDED=(8<<4),
	}
}
