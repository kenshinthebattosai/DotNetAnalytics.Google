using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 103 refers the number/index of the custom metric. Note that the data type of ga:metric103 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 103 refers the number/index of the custom metric. Note that the data type of ga:metric103 can be INTEGER, CURRENCY or TIME.")]
	public class Metric103: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric103" />.
		/// </summary>
		public Metric103(): base("Custom Metric 103 Value",true,"ga:metric103")
		{
			
		}
	}
}

