using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	DCM rendering ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).
	/// </summary>
	[Description("DCM rendering ID of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).")]
	public class DcmLastEventRenderingId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DcmLastEventRenderingId" />.
		/// </summary>
		public DcmLastEventRenderingId(): base("DFA Rendering ID (DFA Model)",false,"ga:dcmLastEventRenderingId")
		{
			
		}
	}
}

