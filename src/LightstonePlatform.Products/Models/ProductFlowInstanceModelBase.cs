namespace LightstonePlatform.Products.Models
{
    public class ProductFlowInstanceModelBase
    {
        public string ProductFlowId { get; set; }
        public ProductFlowInstanceContext Context { get; set; } = new ProductFlowInstanceContext();
        public ProductFlowInstanceMetadata Metadata { get; set; } = new ProductFlowInstanceMetadata();
    }
}