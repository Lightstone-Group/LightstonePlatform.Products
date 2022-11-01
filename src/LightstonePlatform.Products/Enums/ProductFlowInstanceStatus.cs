using System;

namespace LightstonePlatform.Products.Enums
{
    /// <summary>
    /// Status of the product flow
    /// </summary>
    public enum ProductFlowInstanceStatus
    {
        New = 0,
        Inputs_Required = 1,
        Awaiting_Quote = 2,
        Awaiting_Payment = 3,
        /// <summary>
        /// DO NOT USE. This is a vintage enum value that was used before terminal states (rejected or error) were moved to be > 899
        /// </summary>
        [Obsolete("This is a vintage enum value that was used before terminal states (rejected or error) were moved to be > 899", true)]
        Quote_Rejected_Vintage = 4,
        Awaiting_Processing = 5,
        Completed = 6,
        Payment_Success = 7,
        Await_Legal = 8,
        Received_Legal = 9,
        Start_Rejected = 901,
        Start_Error = 1909,
        Validate_Rejected = 911,
        Validate_Error = 1910,
        DuplicateDetection_Error = 1920,
        ProductTerms_Error = 932,
        ProductTerms_Rejected = 934,
        Legal_Rejected = 931,
        Await_Terms = 933,
        Legal_Error = 1930,
        Received_Terms = 934,
        Quote_Rejected = 941,
        Quote_Error = 1940,
        Payment_Rejected = 951,
        Payment_Error = 1950,
        Payment_Expired = 1951,
        Process_Rejected = 961,
        Process_Error = 1960,

    }
}
