using Lightstone.Capabilities.CollectFunds.Dto;

namespace LightstonePlatform.Products.Models
{

    public class ProductFlowInstanceMetadata: ProductFlowInstanceMetadataBase
    {
        public UIMetaData UI { get; set; } = new UIMetaData();
        public PaymentData PaymentData { get; set; }
}
}
