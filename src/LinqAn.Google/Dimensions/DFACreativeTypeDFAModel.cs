namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     DCM creative type name of the last DCM event (impression or click within the DCM lookback window) associated with
    ///     the Google Analytics session (premium only).
    /// </summary>
    public class DFACreativeTypeDFAModel : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACreativeTypeDFAModel" />.
        /// </summary>
        public DFACreativeTypeDFAModel()
            : base(
                "DFA Creative Type (DFA Model)",
                "DCM creative type name of the last DCM event (impression or click within the DCM lookback window) associated with the Google Analytics session (premium only).",
                false, "ga:dcmLastEventCreativeType")
        {
        }
    }
}