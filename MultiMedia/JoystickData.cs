using System;

namespace Win32.MultiMedia
{
	/// <summary>
	/// 
	/// </summary>
	public class JoystickData : EventArgs
	{
		/// <summary>
		/// 
		/// </summary>
		public JoystickData() { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		public JoystickData(uint x)
		{
			// Default
			POV = 65535;
			POVAngle = 655.35;

			R = 32767;
			U = 32767;
			V = 32767;
			X = 32767;
			Y = 32767;
			Z = 32767;

			//Set Values
			X = x;
		}

		/// <summary>
		/// 
		/// </summary>
		public uint ID { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public string Name { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public uint NumberOfAxes { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public uint NumberOfButtons { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public uint R { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public uint U { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public uint V { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public uint X { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public uint Y { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public uint Z { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public uint ButtonPressed { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button01 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button02 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button03 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button04 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button05 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button06 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button07 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button08 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button09 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button10 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button11 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button12 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button13 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button14 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button15 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button16 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button17 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button18 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button19 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button20 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button21 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button22 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button23 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button24 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button25 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button26 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button27 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button28 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button29 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button30 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button31 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public bool Button32 { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public uint POV { get; internal set; }

		/// <summary>
		/// 
		/// </summary>
		public double POVAngle { get; internal set; }
	}
}
