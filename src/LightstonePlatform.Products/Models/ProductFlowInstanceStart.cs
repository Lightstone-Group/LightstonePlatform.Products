namespace LightstonePlatform.Products.Models
{
    public class ProductFlowInstanceStart : ProductFlowInstanceBase
    {
        public new InstanceContext Context { get; set; } = new InstanceContext();
        public new InstanceMetadata Metadata { get; set; } = new InstanceMetadata();
    }
}
