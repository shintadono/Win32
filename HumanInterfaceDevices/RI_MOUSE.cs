using System;

namespace Win32.HumanInterfaceDevices
{
	/// <summary>
	/// Defines the transition state of the mouse buttons.
	/// </summary>
	[CLSCompliant(false)]
	[Flags]
	public enum RI_MOUSE : ushort
	{
		/// <summary>
		/// Left button changed to down.
		/// </summary>
		LEFT_BUTTON_DOWN=0x0001,

		/// <summary>
		/// Left button changed to up.
		/// </summary>
		LEFT_BUTTON_UP=0x0002,

		/// <summary>
		/// Right button changed to down.
		/// </summary>
		RIGHT_BUTTON_DOWN=0x0004,

		/// <summary>
		/// Right button changed to up.
		/// </summary>
		RIGHT_BUTTON_UP=0x0008,

		/// <summary>
		/// Middle button changed to down.
		/// </summary>
		MIDDLE_BUTTON_DOWN=0x0010,

		/// <summary>
		/// Middle button changed to up.
		/// </summary>
		MIDDLE_BUTTON_UP=0x0020,

		/// <summary>
		/// XBUTTON1 changed to down.
		/// </summary>
		XBUTTON1_DOWN=0x0040,

		/// <summary>
		/// XBUTTON1 changed to up.
		/// </summary>
		XBUTTON1_UP=0x0080,

		/// <summary>
		/// XBUTTON2 changed to down.
		/// </summary>
		XBUTTON2_DOWN=0x0100,

		/// <summary>
		/// XBUTTON2 changed to up.
		/// </summary>
		XBUTTON2_UP=0x0200,

		/// <summary>
		/// Raw input comes from a mouse wheel. The wheel delta is stored in <see cref="RAWMOUSE.usButtonData"/>.
		/// </summary>
		WHEEL=0x0400,

		/// <summary>
		/// Raw input comes from a horizontal mouse wheel. The wheel delta is stored in <see cref="RAWMOUSE.usButtonData"/>.
		/// </summary>
		HORIZONTAL_WHEEL=0x0800,

		#region Button 1..5 aliases
		/// <summary>
		/// Button 1 changed to down.
		/// </summary>
		BUTTON_1_DOWN=LEFT_BUTTON_DOWN,

		/// <summary>
		/// Button 1 changed to up.
		/// </summary>
		BUTTON_1_UP=LEFT_BUTTON_UP,
	
		/// <summary>
		/// Button 2 changed to down.
		/// </summary>
		BUTTON_2_DOWN=RIGHT_BUTTON_DOWN,
		
		/// <summary>
		/// Button 2 changed to up.
		/// </summary>
		BUTTON_2_UP=RIGHT_BUTTON_UP,
		
		/// <summary>
		/// Button 3 changed to down.
		/// </summary>
		BUTTON_3_DOWN=MIDDLE_BUTTON_DOWN,

		/// <summary>
		/// Button 3 changed to up.
		/// </summary>
		BUTTON_3_UP=MIDDLE_BUTTON_UP,

		/// <summary>
		/// Button 4 changed to down.
		/// </summary>
		BUTTON_4_DOWN=XBUTTON1_DOWN,

		/// <summary>
		/// Button 4 changed to up.
		/// </summary>
		BUTTON_4_UP=XBUTTON1_UP,

		/// <summary>
		/// Button 5 changed to down.
		/// </summary>
		BUTTON_5_DOWN=XBUTTON2_DOWN,

		/// <summary>
		/// Button 5 changed to up.
		/// </summary>
		BUTTON_5_UP=XBUTTON2_UP,
		#endregion
	}
}
