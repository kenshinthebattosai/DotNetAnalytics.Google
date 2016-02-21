namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The session index for a user. Each session from a unique user will get its own incremental index starting from 1 for the first session. Subsequent sessions do not change previous session indicies. For example, if a certain user has 4 sessions to your website, sessionCount for that user will have 4 distinct values of '1' through '4'.
	/// </summary>
	public class SessionCount: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SessionCount" />.
		/// </summary>
		public SessionCount(): base("Count of Sessions","The session index for a user. Each session from a unique user will get its own incremental index starting from 1 for the first session. Subsequent sessions do not change previous session indicies. For example, if a certain user has 4 sessions to your website, sessionCount for that user will have 4 distinct values of '1' through '4'.",true,"ga:sessionCount")
		{
			
		}
	}
}

