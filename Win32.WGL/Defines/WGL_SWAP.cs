using System;

namespace Win32.WGL
{
	/// <summary>
	/// Bitmask specifying the layer planes for swapping operations.
	/// </summary>
	[Flags]
	public enum WGL_SWAP : uint
	{
		/// <summary>
		/// Main plane.
		/// </summary>
		MAIN_PLANE=0x00000001,

		/// <summary>
		/// 1. Overlay plane.
		/// </summary>
		OVERLAY1=0x00000002,

		/// <summary>
		/// 2. Overlay plane.
		/// </summary>
		OVERLAY2=0x00000004,

		/// <summary>
		/// 3. Overlay plane.
		/// </summary>
		OVERLAY3=0x00000008,

		/// <summary>
		/// 4. Overlay plane.
		/// </summary>
		OVERLAY4=0x00000010,

		/// <summary>
		/// 5. Overlay plane.
		/// </summary>
		OVERLAY5=0x00000020,

		/// <summary>
		/// 6. Overlay plane.
		/// </summary>
		OVERLAY6=0x00000040,

		/// <summary>
		/// 7. Overlay plane.
		/// </summary>
		OVERLAY7=0x00000080,

		/// <summary>
		/// 8. Overlay plane.
		/// </summary>
		OVERLAY8=0x00000100,

		/// <summary>
		/// 9. Overlay plane.
		/// </summary>
		OVERLAY9=0x00000200,

		/// <summary>
		/// 10. Overlay plane.
		/// </summary>
		OVERLAY10=0x00000400,

		/// <summary>
		/// 11. Overlay plane.
		/// </summary>
		OVERLAY11=0x00000800,

		/// <summary>
		/// 12. Overlay plane.
		/// </summary>
		OVERLAY12=0x00001000,

		/// <summary>
		/// 13. Overlay plane.
		/// </summary>
		OVERLAY13=0x00002000,

		/// <summary>
		/// 14. Overlay plane.
		/// </summary>
		OVERLAY14=0x00004000,

		/// <summary>
		/// 15. Overlay plane.
		/// </summary>
		OVERLAY15=0x00008000,

		/// <summary>
		/// 1. Underlay plane.
		/// </summary>
		UNDERLAY1=0x00010000,

		/// <summary>
		/// 2. Underlay plane.
		/// </summary>
		UNDERLAY2=0x00020000,

		/// <summary>
		/// 3. Underlay plane.
		/// </summary>
		UNDERLAY3=0x00040000,

		/// <summary>
		/// 4. Underlay plane.
		/// </summary>
		UNDERLAY4=0x00080000,

		/// <summary>
		/// 5. Underlay plane.
		/// </summary>
		UNDERLAY5=0x00100000,

		/// <summary>
		/// 6. Underlay plane.
		/// </summary>
		UNDERLAY6=0x00200000,

		/// <summary>
		/// 7. Underlay plane.
		/// </summary>
		UNDERLAY7=0x00400000,

		/// <summary>
		/// 8. Underlay plane.
		/// </summary>
		UNDERLAY8=0x00800000,

		/// <summary>
		/// 9. Underlay plane.
		/// </summary>
		UNDERLAY9=0x01000000,

		/// <summary>
		/// 10. Underlay plane.
		/// </summary>
		UNDERLAY10=0x02000000,

		/// <summary>
		/// 11. Underlay plane.
		/// </summary>
		UNDERLAY11=0x04000000,

		/// <summary>
		/// 12. Underlay plane.
		/// </summary>
		UNDERLAY12=0x08000000,

		/// <summary>
		/// 13. Underlay plane.
		/// </summary>
		UNDERLAY13=0x10000000,

		/// <summary>
		/// 14. Underlay plane.
		/// </summary>
		UNDERLAY14=0x20000000,

		/// <summary>
		/// 15. Underlay plane.
		/// </summary>
		UNDERLAY15=0x40000000
	}
}
