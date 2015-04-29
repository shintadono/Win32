using System;

namespace Win32.HumanInterfaceDevices
{
	/// <summary>
	/// Defines the usage of "Human Interface Devices" on Usage Page 2 (Simulation Controls)
	/// </summary>
	[CLSCompliant(false)]
	public static class HID_USAGE_SIMULATION
	{
		/// <summary>
		/// Undefined
		/// </summary>
		public const ushort UNDEFINED=0x00;

		/// <summary>
		/// Flight Simulation Device
		/// </summary>
		public const ushort FLIGHT=0x01;

		/// <summary>
		/// Automobile Simulation Device
		/// </summary>
		public const ushort AUTOMOBILE=0x02;

		/// <summary>
		/// Tank Simulation Device
		/// </summary>
		public const ushort TANK=0x03;

		/// <summary>
		/// Spaceship Simulation Device
		/// </summary>
		public const ushort SPACESHIP=0x04;

		/// <summary>
		/// Submarine Simulation Device
		/// </summary>
		public const ushort SUBMARINE=0x05;

		/// <summary>
		/// Sailing Simulation Device
		/// </summary>
		public const ushort SAILING=0x06;

		/// <summary>
		/// Motorcycle Simulation Device
		/// </summary>
		public const ushort MOTORCYCLE=0x07;

		/// <summary>
		/// Sports Simulation Device
		/// </summary>
		public const ushort SPORTS=0x08;

		/// <summary>
		/// Airplane Simulation Device
		/// </summary>
		public const ushort AIRPLANE=0x09;

		/// <summary>
		/// Helicopter Simulation Device
		/// </summary>
		public const ushort HELICOPTER=0x0A;

		/// <summary>
		/// Magic Carpet Simulation Device
		/// </summary>
		public const ushort MAGIC_CARPET=0x0B;

		/// <summary>
		/// Bicycle
		/// </summary>
		public const ushort BICYCLE=0x0C;

		//public const ushort reserved=0x0d;
		//...
		//public const ushort reserved=0x1f;

		/// <summary>
		/// Flight Control Stick
		/// </summary>
		public const ushort FLIGHT_CONTROL_STICK=0x20;

		/// <summary>
		/// Flight Stick
		/// </summary>
		public const ushort FLIGHT_STICK=0x21;

		/// <summary>
		/// Cyclic Control
		/// </summary>
		public const ushort CYCLIC_CONTROL=0x22;

		/// <summary>
		/// Cyclic Trim
		/// </summary>
		public const ushort CYCLIC_TRIM=0x23;

		/// <summary>
		/// Flight Yoke
		/// </summary>
		public const ushort FLIGHT_YOKE=0x24;

		/// <summary>
		/// Track Control
		/// </summary>
		public const ushort TRACK_CONTROL=0x25;

		///// <summary>
		///// Driving Control
		///// </summary>
		//public const ushort DRIVING_CONTROL=0x26;

		//public const ushort reserved=0x26;
		//...
		//public const ushort reserved=0xaf;

		/// <summary>
		/// Aileron
		/// </summary>
		public const ushort AILERON=0xB0;

		/// <summary>
		/// Aileron Trim
		/// </summary>
		public const ushort AILERON_TRIM=0xB1;

		/// <summary>
		/// Anti-Torque Control
		/// </summary>
		public const ushort ANTI_TORQUE_CONTROL=0xB2;

		/// <summary>
		/// Autopilot Enable
		/// </summary>
		public const ushort AUTOPILOT_ENABLE=0xB3;

		/// <summary>
		/// Chaff Release
		/// </summary>
		public const ushort CHAFF_RELEASE=0xB4;

		/// <summary>
		/// Collective Control
		/// </summary>
		public const ushort COLLECTIVE_CONTROL=0xB5;

		/// <summary>
		/// Dive Brake
		/// </summary>
		public const ushort DIVE_BRAKE=0xB6;

		/// <summary>
		/// Electronic Counter Measures
		/// </summary>
		public const ushort ELECTRONIC_COUNTER_MEASURES=0xB7;

		/// <summary>
		/// Elevator
		/// </summary>
		public const ushort ELEVATOR=0xB8;

		/// <summary>
		/// Elevator Trim
		/// </summary>
		public const ushort ELEVATOR_TRIM=0xB9;

		/// <summary>
		/// Rudder
		/// </summary>
		public const ushort RUDDER=0xBA;

		/// <summary>
		/// Throttle
		/// </summary>
		public const ushort THROTTLE=0xBB;

		/// <summary>
		/// Flight Communication
		/// </summary>
		public const ushort FLIGHT_COMMUNICATION=0xBC;

		/// <summary>
		/// Flare Release
		/// </summary>
		public const ushort FLARE_RELEASE=0xBD;

		/// <summary>
		/// Landing Gear
		/// </summary>
		public const ushort LANDING_GEAR=0xBE;

		/// <summary>
		/// Toe Brake
		/// </summary>
		public const ushort TOE_BRAKE=0xBF;

		/// <summary>
		/// Trigger
		/// </summary>
		public const ushort TRIGGER=0xC0;

		/// <summary>
		/// Weapons Arm
		/// </summary>
		public const ushort WEAPONS_ARM=0xC1;

		/// <summary>
		/// Weapons Select
		/// </summary>
		public const ushort WEAPONS_SELECT=0xC2;

		/// <summary>
		/// Wing Flaps
		/// </summary>
		public const ushort WING_FLAPS=0xC3;

		/// <summary>
		/// Accelerator
		/// </summary>
		public const ushort ACCELERATOR=0xC4;

		/// <summary>
		/// Brake
		/// </summary>
		public const ushort BRAKE=0xC5;

		/// <summary>
		/// Clutch
		/// </summary>
		public const ushort CLUTCH=0xC6;

		/// <summary>
		/// Shifter
		/// </summary>
		public const ushort SHIFTER=0xC7;

		/// <summary>
		/// Steering
		/// </summary>
		public const ushort STEERING=0xC8;

		/// <summary>
		/// Turret Direction
		/// </summary>
		public const ushort TURRET_DIRECTION=0xC9;

		/// <summary>
		/// Barrel Elevation
		/// </summary>
		public const ushort BARREL_ELEVATION=0xCA;

		/// <summary>
		/// Dive Plane
		/// </summary>
		public const ushort DIVE_PLANE=0xCB;

		/// <summary>
		/// Ballast
		/// </summary>
		public const ushort BALLAST=0xCC;

		/// <summary>
		/// Bicycle Crank
		/// </summary>
		public const ushort BICYCLE_CRANK=0xCD;

		/// <summary>
		/// Handle Bars
		/// </summary>
		public const ushort HANDLE_BARS=0xCE;

		/// <summary>
		/// Front Brake
		/// </summary>
		public const ushort FRONT_BRAKE=0xCF;

		/// <summary>
		/// Rear Brake
		/// </summary>
		public const ushort REAR_BRAKE=0xD0;

		//public const ushort reserved=0xd1;
		//...
		//public const ushort reserved=0xffff;
	}
}
