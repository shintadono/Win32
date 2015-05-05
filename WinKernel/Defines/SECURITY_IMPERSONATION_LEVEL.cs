namespace Win32
{
	/// <summary>
	/// Defines the impersonation levels that determine the operations a server can perform in the client's context.
	/// </summary>
	public enum SECURITY_IMPERSONATION_LEVEL
	{
		/// <summary>
		/// The server cannot impersonate or identify the client.
		/// </summary>
		SecurityAnonymous=0,

		/// <summary>
		/// The server can get the identity and privileges of the client, but cannot impersonate the client.
		/// </summary>
		SecurityIdentification=1,

		/// <summary>
		/// The server can impersonate the client's security context on the local system.
		/// </summary>
		SecurityImpersonation=2,

		/// <summary>
		/// The server can impersonate the client's security context on remote systems.
		/// </summary>
		SecurityDelegation=3,
	}
}
