namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The country ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-1 alpha-2 code.
	/// </summary>
	public class CountryIsoCode: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CountryIsoCode" />.
		/// </summary>
		public CountryIsoCode(): base("Country ISO Code","The country ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-1 alpha-2 code.",false,"ga:countryIsoCode")
		{
			
		}
	}
}

