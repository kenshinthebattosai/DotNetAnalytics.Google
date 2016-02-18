namespace DotNetAnalytics.Google.Dimensions
{
	public class ScreenColorsDimension: Dimension<string>
	{
		/// <summary>
		/// 	The color depth of users' monitors, as retrieved from the DOM of the user's browser. For example 4-bit, 8-bit, 24-bit, or undefined-bit.
		/// </summary>
		public ScreenColorsDimension(): base("Screen Colors","The color depth of users' monitors, as retrieved from the DOM of the user's browser. For example 4-bit, 8-bit, 24-bit, or undefined-bit.",true,"ga:screenColors")
		{
			
		}
	}
}

