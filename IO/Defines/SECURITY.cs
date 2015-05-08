using System;

namespace Win32.IO
{
	/// <summary>
	/// Defines security quality of service flags.
	/// </summary>
	[CLSCompliant(false)]
	[Flags]
	public enum SECURITY : uint
	{
		/// <summary>
		/// Impersonates a client at the Anonymous impersonation level.
		/// </summary>
		ANONYMOUS=SECURITY_IMPERSONATION_LEVEL.SecurityAnonymous<<16,

		/// <summary>
		/// Impersonates a client at the Identification impersonation level.
		/// </summary>
		IDENTIFICATION=SECURITY_IMPERSONATION_LEVEL.SecurityIdentification<<16,

		/// <summary>
		/// Impersonate a client at the impersonation level. This is the default behavior
		/// if no other flags are specified along with the SECURITY_SQOS_PRESENT flag.
		/// </summary>
		IMPERSONATION=SECURITY_IMPERSONATION_LEVEL.SecurityImpersonation<<16,

		/// <summary>
		/// Impersonates a client at the Delegation impersonation level.
		/// </summary>
		DELEGATION=SECURITY_IMPERSONATION_LEVEL.SecurityDelegation<<16,

		/// <summary>
		/// The security tracking mode is dynamic. If this flag is not specified, the
		/// security tracking mode is static.
		/// </summary>
		CONTEXT_TRACKING=0x00040000,

		/// <summary>
		/// <para>Only the enabled aspects of the client's security context are available
		/// to the server. If you do not specify this flag, all aspects of the client's
		/// security context are available.</para>
		/// <para>This allows the client to limit the groups and privileges that a server
		/// can use while impersonating the client.</para>
		/// </summary>
		EFFECTIVE_ONLY=0x00080000,
	}
}
