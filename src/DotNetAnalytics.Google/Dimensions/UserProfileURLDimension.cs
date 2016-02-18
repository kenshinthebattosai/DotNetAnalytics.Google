namespace DotNetAnalytics.Google.Dimensions
{
	public class UserProfileURLDimension: Dimension<string>
	{
		/// <summary>
		/// 	For a social data hub activity, this value represents the URL of the associated user's social network profile.
		/// </summary>
		public UserProfileURLDimension(): base("User Profile URL","For a social data hub activity, this value represents the URL of the associated user's social network profile.",false,"ga:socialActivityUserProfileUrl")
		{
			
		}
	}
}

