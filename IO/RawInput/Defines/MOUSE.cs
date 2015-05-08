using System;

namespace Win32.RawInput
{
	/// <summary>
	/// Defines the mouse state.
	/// </summary>
	[CLSCompliant(false)]
	[Flags]
	public enum MOUSE : ushort
	{
		/// <summary>
		/// Mouse movement data is relative to the last mouse position.
		/// </summary>
		MOVE_RELATIVE=0x00,

		/// <summary>
		/// Mouse movement data is based on absolute position.
		/// </summary>
		MOVE_ABSOLUTE=0x01,

		/// <summary>
		/// Mouse coordinates are mapped to the virtual desktop (for a multiple monitor system).
		/// </summary>
		VIRTUAL_DESKTOP=0x02,

		/// <summary>
		/// Mouse attributes changed; application needs to query the mouse attributes.
		/// </summary>
		ATTRIBUTES_CHANGED=0x04,

		/// <summary>
		/// Do not coalesce mouse moves.
		/// </summary>
		MOVE_NOCOALESCE=0x08,
	}
}
