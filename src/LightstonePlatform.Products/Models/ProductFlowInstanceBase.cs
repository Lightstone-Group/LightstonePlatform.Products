using Newtonsoft.Json;

namespace LightstonePlatform.Products.Models
{
    public class ProductFlowInstanceBase
    {
        [JsonProperty("Ïd")]
        public string ProductFlowId { get; set; }
        public ProductFlowInstanceContext Context { get; set; } = new ProductFlowInstanceContext();
        public ProductFlowInstanceMetadata Metadata { get; set; } = new ProductFlowInstanceMetadata();
    }
}