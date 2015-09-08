using System;
using System.Collections.Generic;
using System.Text;

namespace Win32.MultiMedia
{
	/// <summary>
	/// http://www.activevb.de/cgi-bin/apiwiki/JOYINFOEX
	/// http://msdn.microsoft.com/en-us/library/dd757108%28VS.85%29.aspx
	/// http://www.activevb.de/cgi-bin/apiwiki/JoyGetPosEx
	/// http://msdn.microsoft.com/en-us/library/dd757112(VS.85).aspx
	/// </summary>
	public class Joystick
	{
		static uint MAX_JOYSTICK_DEVICES = WinMM.joyGetNumDevs();

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static List<Joystick> GetJoysticks()
		{
			List<Joystick> ret = new List<Joystick>();

			WinMM.JOYCAPS tmpJoyCaps = new WinMM.JOYCAPS();

			for (uint i = 0; i < MAX_JOYSTICK_DEVICES; i++)
			{
				if (WinMM.joyGetDevCaps((UIntPtr)i, ref tmpJoyCaps, 404) == WinMM.JOYERR_NOERROR) // Get joystick info
				{
					WinMM.JOYINFO joyinfo = new WinMM.JOYINFO();
					if (WinMM.joyGetPos(i, ref joyinfo) == WinMM.JOYERR_NOERROR)
					{
						ret.Add(new Joystick(i));
					}
				}
			}

			return ret;
		}

		#region Properties
		/// <summary>
		/// 
		/// </summary>
		public uint R
		{
			get
			{
				return GetJoyInfoEx().dwRpos;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public uint U
		{
			get
			{
				return GetJoyInfoEx().dwUpos;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public uint V
		{
			get
			{
				return GetJoyInfoEx().dwVpos;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public uint X
		{
			get
			{
				return GetJoyInfoEx().dwXpos;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public uint Y
		{
			get
			{
				return GetJoyInfoEx().dwYpos;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public uint Z
		{
			get
			{
				return GetJoyInfoEx().dwZpos;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public uint ButtonPressed
		{
			get
			{
				return GetJoyInfoEx().dwButtonNumber;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public bool Button01 { get { return GetButtonState(WinMM.JOY_BUTTON1); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button02 { get { return GetButtonState(WinMM.JOY_BUTTON2); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button03 { get { return GetButtonState(WinMM.JOY_BUTTON3); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button04 { get { return GetButtonState(WinMM.JOY_BUTTON4); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button05 { get { return GetButtonState(WinMM.JOY_BUTTON5); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button06 { get { return GetButtonState(WinMM.JOY_BUTTON6); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button07 { get { return GetButtonState(WinMM.JOY_BUTTON7); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button08 { get { return GetButtonState(WinMM.JOY_BUTTON8); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button09 { get { return GetButtonState(WinMM.JOY_BUTTON9); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button10 { get { return GetButtonState(WinMM.JOY_BUTTON10); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button11 { get { return GetButtonState(WinMM.JOY_BUTTON11); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button12 { get { return GetButtonState(WinMM.JOY_BUTTON12); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button13 { get { return GetButtonState(WinMM.JOY_BUTTON13); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button14 { get { return GetButtonState(WinMM.JOY_BUTTON14); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button15 { get { return GetButtonState(WinMM.JOY_BUTTON15); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button16 { get { return GetButtonState(WinMM.JOY_BUTTON16); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button17 { get { return GetButtonState(WinMM.JOY_BUTTON17); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button18 { get { return GetButtonState(WinMM.JOY_BUTTON18); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button19 { get { return GetButtonState(WinMM.JOY_BUTTON19); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button20 { get { return GetButtonState(WinMM.JOY_BUTTON20); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button21 { get { return GetButtonState(WinMM.JOY_BUTTON21); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button22 { get { return GetButtonState(WinMM.JOY_BUTTON22); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button23 { get { return GetButtonState(WinMM.JOY_BUTTON23); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button24 { get { return GetButtonState(WinMM.JOY_BUTTON24); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button25 { get { return GetButtonState(WinMM.JOY_BUTTON25); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button26 { get { return GetButtonState(WinMM.JOY_BUTTON26); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button27 { get { return GetButtonState(WinMM.JOY_BUTTON27); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button28 { get { return GetButtonState(WinMM.JOY_BUTTON28); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button29 { get { return GetButtonState(WinMM.JOY_BUTTON29); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button30 { get { return GetButtonState(WinMM.JOY_BUTTON30); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button31 { get { return GetButtonState(WinMM.JOY_BUTTON31); } }

		/// <summary>
		/// 
		/// </summary>
		public bool Button32 { get { return GetButtonState(WinMM.JOY_BUTTON32); } }

		/// <summary>
		/// 
		/// </summary>
		public uint POV
		{
			get
			{
				return GetJoyInfoEx().dwPOV;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public double POVAngle
		{
			get
			{
				return GetJoyInfoEx().dwPOV / 100.0;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public uint ID { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		public bool HasZ { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		public bool HasR { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		public bool HasU { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		public bool HasV { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		public bool HasPOV { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		public bool IsPOV4DIR { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		public bool IsPOVCTS { get; private set; }


		/// <summary>
		/// 
		/// </summary>
		public uint NumberOfAxes { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		public uint NumberOfButtons { get; private set; }
		#endregion


		/// <summary>
		/// 
		/// </summary>
		public Joystick(uint joyNum)
		{
			WinMM.JOYCAPS joyCaps = new WinMM.JOYCAPS();

			if (WinMM.joyGetDevCaps((UIntPtr)joyNum, ref joyCaps, 404) != 0) //Get joystick info
			{
				throw new Exception("Joystick is not ready.");
			}

			ID = joyNum;
			Name = joyCaps.szPname;

			HasZ = (joyCaps.wCaps & WinMM.JOYCAPS_HASZ) != 0;
			HasR = (joyCaps.wCaps & WinMM.JOYCAPS_HASR) != 0;
			HasU = (joyCaps.wCaps & WinMM.JOYCAPS_HASU) != 0;
			HasV = (joyCaps.wCaps & WinMM.JOYCAPS_HASV) != 0;
			HasPOV = (joyCaps.wCaps & WinMM.JOYCAPS_HASPOV) != 0;
			IsPOV4DIR = (joyCaps.wCaps & WinMM.JOYCAPS_POV4DIR) != 0;
			IsPOVCTS = (joyCaps.wCaps & WinMM.JOYCAPS_POVCTS) != 0;

			NumberOfAxes = joyCaps.wNumAxes;
			NumberOfButtons = joyCaps.wNumButtons;
		}


		/// <summary>
		/// 
		/// </summary>
		public JoystickData GetState()
		{
			JoystickData ret = new JoystickData();
			WinMM.JOYINFOEX tmpJoyInfo = GetJoyInfoEx();

			ret.ID = ID;
			ret.Name = Name;

			ret.NumberOfAxes = NumberOfAxes;
			ret.NumberOfButtons = NumberOfButtons;

			ret.R = tmpJoyInfo.dwRpos;
			ret.U = tmpJoyInfo.dwUpos;
			ret.V = tmpJoyInfo.dwVpos;
			ret.X = tmpJoyInfo.dwXpos;
			ret.Y = tmpJoyInfo.dwYpos;
			ret.Z = tmpJoyInfo.dwZpos;

			ret.Button01 = GetButtonState(WinMM.JOY_BUTTON1, tmpJoyInfo);
			ret.Button02 = GetButtonState(WinMM.JOY_BUTTON2, tmpJoyInfo);
			ret.Button03 = GetButtonState(WinMM.JOY_BUTTON3, tmpJoyInfo);
			ret.Button04 = GetButtonState(WinMM.JOY_BUTTON4, tmpJoyInfo);
			ret.Button05 = GetButtonState(WinMM.JOY_BUTTON5, tmpJoyInfo);
			ret.Button06 = GetButtonState(WinMM.JOY_BUTTON6, tmpJoyInfo);
			ret.Button07 = GetButtonState(WinMM.JOY_BUTTON7, tmpJoyInfo);
			ret.Button08 = GetButtonState(WinMM.JOY_BUTTON8, tmpJoyInfo);
			ret.Button09 = GetButtonState(WinMM.JOY_BUTTON9, tmpJoyInfo);
			ret.Button10 = GetButtonState(WinMM.JOY_BUTTON10, tmpJoyInfo);
			ret.Button11 = GetButtonState(WinMM.JOY_BUTTON11, tmpJoyInfo);
			ret.Button12 = GetButtonState(WinMM.JOY_BUTTON12, tmpJoyInfo);
			ret.Button13 = GetButtonState(WinMM.JOY_BUTTON13, tmpJoyInfo);
			ret.Button14 = GetButtonState(WinMM.JOY_BUTTON14, tmpJoyInfo);
			ret.Button15 = GetButtonState(WinMM.JOY_BUTTON15, tmpJoyInfo);
			ret.Button16 = GetButtonState(WinMM.JOY_BUTTON16, tmpJoyInfo);
			ret.Button17 = GetButtonState(WinMM.JOY_BUTTON17, tmpJoyInfo);
			ret.Button18 = GetButtonState(WinMM.JOY_BUTTON18, tmpJoyInfo);
			ret.Button19 = GetButtonState(WinMM.JOY_BUTTON19, tmpJoyInfo);
			ret.Button20 = GetButtonState(WinMM.JOY_BUTTON20, tmpJoyInfo);
			ret.Button21 = GetButtonState(WinMM.JOY_BUTTON21, tmpJoyInfo);
			ret.Button22 = GetButtonState(WinMM.JOY_BUTTON22, tmpJoyInfo);
			ret.Button23 = GetButtonState(WinMM.JOY_BUTTON23, tmpJoyInfo);
			ret.Button24 = GetButtonState(WinMM.JOY_BUTTON24, tmpJoyInfo);
			ret.Button25 = GetButtonState(WinMM.JOY_BUTTON25, tmpJoyInfo);
			ret.Button26 = GetButtonState(WinMM.JOY_BUTTON26, tmpJoyInfo);
			ret.Button27 = GetButtonState(WinMM.JOY_BUTTON27, tmpJoyInfo);
			ret.Button28 = GetButtonState(WinMM.JOY_BUTTON28, tmpJoyInfo);
			ret.Button29 = GetButtonState(WinMM.JOY_BUTTON29, tmpJoyInfo);
			ret.Button30 = GetButtonState(WinMM.JOY_BUTTON30, tmpJoyInfo);
			ret.Button31 = GetButtonState(WinMM.JOY_BUTTON31, tmpJoyInfo);
			ret.Button32 = GetButtonState(WinMM.JOY_BUTTON32, tmpJoyInfo);

			ret.POV = tmpJoyInfo.dwPOV;
			ret.POVAngle = tmpJoyInfo.dwPOV / 100.0;

			return ret;
		}

		bool GetButtonState(UInt32 button, WinMM.JOYINFOEX joyinfo)
		{
			uint tmp = joyinfo.dwButtons & button;
			if (tmp == 0) return false;
			else return true;
		}

		bool GetButtonState(UInt32 button)
		{
			uint tmp = GetJoyInfoEx().dwButtons & button;
			if (tmp == 0) return false;
			else return true;
		}

		WinMM.JOYINFOEX GetJoyInfoEx()
		{
			WinMM.JOYINFOEX joyInfoEx = new WinMM.JOYINFOEX();

			joyInfoEx.dwSize = 64;
			joyInfoEx.dwFlags = 0x2ff;

			WinMM.joyGetPosEx(ID, ref joyInfoEx);

			// Center if not available!
			if (!HasPOV) joyInfoEx.dwPOV = WinMM.JOY_POVCENTERED;
			if (!HasZ) joyInfoEx.dwZpos = 0x7fff;
			if (!HasR) joyInfoEx.dwRpos = 0x7fff;
			if (!HasU) joyInfoEx.dwUpos = 0x7fff;
			if (!HasV) joyInfoEx.dwVpos = 0x7fff;

			return joyInfoEx;
		}
	}
}