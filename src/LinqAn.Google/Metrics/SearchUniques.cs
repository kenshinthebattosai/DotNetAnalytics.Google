namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of unique keywords from internal searches within a session. For example if "shoes" was searched for 3 times in a session, it will be only counted once.
	/// </summary>
	public class SearchUniques: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SearchUniques" />.
		/// </summary>
		public SearchUniques(): base("Total Unique Searches","The total number of unique keywords from internal searches within a session. For example if \"shoes\" was searched for 3 times in a session, it will be only counted once.",true,"ga:searchUniques")
		{
			
		}
	}
}

