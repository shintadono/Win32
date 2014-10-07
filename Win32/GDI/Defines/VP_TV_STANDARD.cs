namespace Win32
{
	/// <summary>
	/// Specifies the television standard.
	/// </summary>
	public enum VP_TV_STANDARD : uint
	{
		/// <summary>
		/// NTSC television standard, type M.
		/// </summary>
		NTSC_M=0x00000001,

		/// <summary>
		/// NTSC television standard, type M, for Japan.
		/// </summary>
		NTSC_M_J=0x00000002,

		/// <summary>
		/// PAL television standard, type B.
		/// </summary>
		PAL_B=0x00000004,

		/// <summary>
		/// PAL television standard, type D.
		/// </summary>
		PAL_D=0x00000008,

		/// <summary>
		/// PAL television standard, type H.
		/// </summary>
		PAL_H=0x00000010,

		/// <summary>
		/// PAL television standard, type I.
		/// </summary>
		PAL_I=0x00000020,

		/// <summary>
		/// PAL television standard, type M.
		/// </summary>
		PAL_M=0x00000040,

		/// <summary>
		/// PAL television standard, type N.
		/// </summary>
		PAL_N=0x00000080,

		/// <summary>
		/// Systeme Electronique Couleur avec Memoire (SECAM) television standard, type B.
		/// </summary>
		SECAM_B=0x00000100,

		/// <summary>
		/// SECAM television standard, type D.
		/// </summary>
		SECAM_D=0x00000200,

		/// <summary>
		/// SECAM television standard, type G.
		/// </summary>
		SECAM_G=0x00000400,

		/// <summary>
		/// SECAM television standard, type H.
		/// </summary>
		SECAM_H=0x00000800,

		/// <summary>
		/// SECAM television standard, type K.
		/// </summary>
		SECAM_K=0x00001000,

		/// <summary>
		/// SECAM television standard, type K1.
		/// </summary>
		SECAM_K1=0x00002000,

		/// <summary>
		/// SECAM television standard, type L.
		/// </summary>
		SECAM_L=0x00004000,

		/// <summary>
		/// Video Graphic Adapter (VGA) monitor.
		/// </summary>
		WIN_VGA=0x00008000,

		/// <summary>
		/// National Television Systems Committee (NTSC) video standard, with a subcarrier frequency of 4.33 megahertz (MHz).
		/// </summary>
		NTSC_433=0x00010000,

		/// <summary>
		/// PAL television standard, type G.
		/// </summary>
		PAL_G=0x00020000,

		/// <summary>
		/// Phase Alternation Line (PAL) 60 video standard that is used to play NTSC video.
		/// </summary>
		PAL_60=0x00040000,

		/// <summary>
		/// SECAM television standard, type L1.
		/// </summary>
		SECAM_L1=0x00080000,
	}
}
