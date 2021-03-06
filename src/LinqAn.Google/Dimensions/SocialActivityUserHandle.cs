using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	For a social data hub activity, this value represents the social network handle (e.g. name or ID) of the user who initiated the social activity.
	/// </summary>
	[Description("For a social data hub activity, this value represents the social network handle (e.g. name or ID) of the user who initiated the social activity.")]
	public class SocialActivityUserHandle: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialActivityUserHandle" />.
		/// </summary>
		public SocialActivityUserHandle(): base("Social User Handle",false,"ga:socialActivityUserHandle")
		{
			
		}
	}
}

