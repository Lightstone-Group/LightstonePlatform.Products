using System;
using System.Collections.Generic;

namespace LightstonePlatform.Products.Models
{

    [Serializable]
    public class ProductFlowInstanceMetadata: ProductFlowInstanceMetadataBase
    {
        public List<QuoteLineItemCaptureModel> LineItems { get; set; } = new List<QuoteLineItemCaptureModel>();
        public UIMetaData UI { get; set; } = new UIMetaData();
    }
}
