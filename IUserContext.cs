using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammophone.Domos.Environment
{
	/// <summary>
	/// Bridges the authentication environment to the 
	/// logic layer. Used when the logic session dicovers the current user
	/// instead of having her specified.
	/// </summary>
	public interface IUserContext
	{
		/// <summary>
		/// The ID of the authenticated, registered user,
		/// else null if the user is anonymous.
		/// </summary>
		long? UserID { get; }
	}
}
