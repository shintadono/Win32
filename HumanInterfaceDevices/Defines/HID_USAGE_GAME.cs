namespace Win32.HumanInterfaceDevices
{
	/// <summary>
	/// Defines the usage of "Human Interface Devices" on Usage Page 5 (Game Controls)
	/// </summary>
	public static class HID_USAGE_GAME
	{
		/// <summary>
		/// Undefined
		/// </summary>
		public const ushort UNDEFINED=0x00;

		/// <summary>
		/// 3D Game Controller
		/// </summary>
		public const ushort D3_GAME=0x01;

		/// <summary>
		/// Pinball Device
		/// </summary>
		public const ushort PINBALL=0x02;

		/// <summary>
		/// Gun Device
		/// </summary>
		public const ushort GUN=0x03;

		//public const ushort reserved=0x04;
		//...
		//public const ushort reserved=0x2f;

		/// <summary>
		/// Point of View
		/// </summary>
		public const ushort POINT_OF_VIEW=0x20;

		/// <summary>
		/// Turn Right/Left
		/// </summary>
		public const ushort TURN=0x21;

		/// <summary>
		/// Pitch Right/Left
		/// </summary>
		public const ushort PITCH=0x22;

		/// <summary>
		/// Roll Forward/Backward
		/// </summary>
		public const ushort ROLL=0x23;

		/// <summary>
		/// Move Right/Left
		/// </summary>
		public const ushort MOVE_RIGHT_LEFT=0x24;

		/// <summary>
		/// Move Forward/Backward
		/// </summary>
		public const ushort MOVE_FORWARD_BACKWARD=0x25;

		/// <summary>
		/// Move Up/Down
		/// </summary>
		public const ushort MOVE_UP_DOWN=0x26;

		/// <summary>
		/// Lean Right/Left
		/// </summary>
		public const ushort LEAN_RIGHT_LEFT=0x27;

		/// <summary>
		/// Lean Forward/Backward
		/// </summary>
		public const ushort LEAN_FORWARD_BACKWARD=0x28;

		/// <summary>
		/// Height of POV
		/// </summary>
		public const ushort HEIGHT_OF_POV=0x29;

		/// <summary>
		/// Flipper
		/// </summary>
		public const ushort FLIPPER=0x2A;

		/// <summary>
		/// Secondary Flipper
		/// </summary>
		public const ushort SECONDARY_FLIPPER=0x2B;

		/// <summary>
		/// Bump
		/// </summary>
		public const ushort BUMP=0x2C;

		/// <summary>
		/// New Game
		/// </summary>
		public const ushort NEW_GAME=0x2D;

		/// <summary>
		/// Shoot Ball	
		/// </summary>
		public const ushort SHOOT_BALL=0x2E;

		/// <summary>
		/// Player
		/// </summary>
		public const ushort PLAYER=0x2F;

		/// <summary>
		/// Gun Bolt
		/// </summary>
		public const ushort GUN_BOLT=0x30;

		/// <summary>
		/// Gun Clip
		/// </summary>
		public const ushort GUN_CLIP=0x31;

		/// <summary>
		///  Gun Selector
		/// </summary>
		public const ushort GUN_SELECTOR=0x32;

		/// <summary>
		/// Gun Single Shot
		/// </summary>
		public const ushort GUN_SINGLE_SHOT=0x33;

		/// <summary>
		/// Gun Burst
		/// </summary>
		public const ushort GUN_BURST=0x34;

		/// <summary>
		/// Gun Automatic
		/// </summary>
		public const ushort GUN_AUTOMATIC=0x35;

		/// <summary>
		/// Gun Safety
		/// </summary>
		public const ushort GUN_SAFETY=0x36;

		/// <summary>
		/// Gamepad Fire/Jump
		/// </summary>
		public const ushort GAMEPAD_FIRE_JUMP=0x37;

		/// <summary>
		/// Gamepad Trigger
		/// </summary>
		public const ushort GAMEPAD_TRIGGER=0x39;

		//public const ushort reserved=0x3a;
		//...
		//public const ushort reserved=0xffff;
	}
}
