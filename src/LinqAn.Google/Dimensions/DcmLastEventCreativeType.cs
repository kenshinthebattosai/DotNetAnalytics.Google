using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM creative type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM creative type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).")]
	public class DcmLastEventCreativeType: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventCreativeType" />.
		/// </summary>
		public DcmLastEventCreativeType(): base("DFA Creative Type (DFA Model)",false,"ga:dcmLastEventCreativeType")
		{
			
		}
	}
}

