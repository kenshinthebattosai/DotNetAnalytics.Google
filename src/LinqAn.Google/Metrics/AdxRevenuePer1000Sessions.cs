namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total estimated revenue from AdX ads per 1000 Analytics sessions. Note that this metric is based on sessions to your site and not ad impressions.
	/// </summary>
	public class AdxRevenuePer1000Sessions: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdxRevenuePer1000Sessions" />.
		/// </summary>
		public AdxRevenuePer1000Sessions(): base("AdX Revenue / 1000 Sessions","The total estimated revenue from AdX ads per 1000 Analytics sessions. Note that this metric is based on sessions to your site and not ad impressions.",false,"ga:adxRevenuePer1000Sessions")
		{
			
		}
	}
}
