using System;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class ProductFlowInstanceBase
    {
        public string ProductFlowId { get; set; }
        public string SourceDataUrl { get; set; }
        public ProductFlowInstanceContext Context { get; set; } = new ProductFlowInstanceContext();
        public ProductFlowInstanceMetadata Metadata { get; set; } = new ProductFlowInstanceMetadata();
        public string CustomizationHash { get; set; }
        public string PartyId { get; set; }
        public string TenantId { get; set; }
    }
}
