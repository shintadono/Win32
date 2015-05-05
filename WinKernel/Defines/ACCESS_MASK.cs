using System;

namespace Win32
{
	/// <summary>
	/// Defines the access mask.
	/// </summary>
	/// <remarks>
	/// <para>A <b>uint</b> combining different rights.</para>
	/// <para>Generic access rights are stored in the four uppermost bits (bits 28-31).</para>
	/// <para>The SACL access right is stored in bit 24.</para>
	/// <para>Standard access rights are stored in the bits 16-23.</para>
	/// <para>Specific (access) rights are stored in the lowermost bits 0-15.</para>
	/// <para>The values in this enum are provided for simpler use of the acces mask. Just OR
	/// them together to your needs.</para>
	/// </remarks>
	[CLSCompliant(false)]
	[Flags]
	public enum ACCESS_MASK : uint
	{
		#region Generic access rights
		/// <summary>
		/// Read access
		/// </summary>
		GENERIC_READ=0x80000000,

		/// <summary>
		/// Write access
		/// </summary>
		GENERIC_WRITE=0x40000000,

		/// <summary>
		/// Execute access
		/// </summary>
		GENERIC_EXECUTE=0x20000000,

		/// <summary>
		/// All possible access rights
		/// </summary>
		GENERIC_ALL=0x10000000,
		#endregion

		/// <summary>
		/// SACL access right
		/// </summary>
		ACCESS_SYSTEM_SECURITY=0x01000000,

		#region Standard access rights
		/// <summary>
		/// The right to delete the object.
		/// </summary>
		DELETE=0x00010000,

		/// <summary>
		/// The right to read the information in the object's security descriptor,
		/// not including the information in the system access control list (SACL).
		/// </summary>
		READ_CONTROL=0x00020000,

		/// <summary>
		/// The right to modify the discretionary access control list (DACL) in
		/// the object's security descriptor.
		/// </summary>
		WRITE_DAC=0x00040000,

		/// <summary>
		/// The right to change the owner in the object's security descriptor.
		/// </summary>
		WRITE_OWNER=0x00080000,

		/// <summary>
		/// The right to use the object for synchronization. This enables a
		/// thread to wait until the object is in the signaled state. Some object
		/// types do not support this access right.
		/// </summary>
		SYNCHRONIZE=0x00100000,

		/// <summary>
		/// Combines <see cref="DELETE"/>, <see cref="READ_CONTROL"/>, <see cref="WRITE_DAC"/> and <see cref="WRITE_OWNER"/> access.
		/// </summary>
		STANDARD_RIGHTS_REQUIRED=WRITE_OWNER|WRITE_DAC|READ_CONTROL|DELETE,

		/// <summary>
		/// Currently defined to equal <see cref="READ_CONTROL"/>.
		/// </summary>
		STANDARD_RIGHTS_READ=READ_CONTROL,

		/// <summary>
		/// Currently defined to equal <see cref="READ_CONTROL"/>.
		/// </summary>
		STANDARD_RIGHTS_WRITE=READ_CONTROL,

		/// <summary>
		/// Currently defined to equal <see cref="READ_CONTROL"/>.
		/// </summary>
		STANDARD_RIGHTS_EXECUTE=READ_CONTROL,

		/// <summary>
		/// Combines <see cref="DELETE"/>, <see cref="READ_CONTROL"/>, <see cref="WRITE_DAC"/>, <see cref="WRITE_OWNER"/> and <see cref="SYNCHRONIZE"/> access.
		/// </summary>
		STANDARD_RIGHTS_ALL=SYNCHRONIZE|WRITE_OWNER|WRITE_DAC|READ_CONTROL|DELETE,
		#endregion

		/// <summary>
		/// Mask for specific rights.
		/// </summary>
		SPECIFIC_RIGHTS_ALL=0x0000FFFF,

		/// <summary>
		/// Maximum allowed access type.
		/// </summary>
		MAXIMUM_ALLOWED=0x02000000,
	}
}
