using System;

namespace Win32
{
	/// <summary>
	/// Specifies how the DC is created.
	/// </summary>
	[Flags]
	public enum DCX : uint
	{
		/// <summary>
		/// Returns a DC that corresponds to the window rectangle rather than the client rectangle.
		/// </summary>
		WINDOW=0x00000001,

		/// <summary>
		/// Returns a DC from the cache, rather than the <b>OWNDC</b> or <b>CLASSDC</b> window. Essentially overrides <b>CS_OWNDC</b> and <b>CS_CLASSDC</b>.
		/// </summary>
		CACHE=0x00000002,

		/// <summary>
		/// Uses the visible region of the parent window. The parent's <b>WS_CLIPCHILDREN</b> and <b>CS_PARENTDC</b> style bits are ignored. The origin is set to the upper-left corner of the window.
		/// </summary>
		PARENTCLIP=0x00000020,

		/// <summary>
		/// Excludes the visible regions of all sibling windows above the window.
		/// </summary>
		CLIPSIBLINGS=0x00000010,

		/// <summary>
		/// Excludes the visible regions of all child windows below the window.
		/// </summary>
		CLIPCHILDREN=0x00000008,

		/// <summary>
		/// Does not reset the attributes of this DC to the default attributes when this DC is released.
		/// </summary>
		NORESETATTRS=0x00000004,

		/// <summary>
		/// Allows drawing even if there is a <b>LockWindowUpdate</b> call in effect that would otherwise exclude this window. Used for drawing during tracking.
		/// </summary>
		LOCKWINDOWUPDATE=0x00000400,

		/// <summary>
		/// The clipping region is excluded from the visible region of the returned DC.
		/// </summary>
		EXCLUDERGN=0x00000040,

		/// <summary>
		/// The clipping region is intersected with the visible region of the returned DC.
		/// </summary>
		INTERSECTRGN=0x00000080,

		/// <summary>
		/// Reserved; do not use.
		/// </summary>
		INTERSECTUPDATE=0x00000200,

		/// <summary>
		/// Reserved; do not use.
		/// </summary>
		VALIDATE=0x00200000,
	}
}
