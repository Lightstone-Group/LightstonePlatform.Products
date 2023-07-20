using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace LightstonePlatform.Products.Models
{
    public class ProductFlowInstanceBase
    {
        public string ProductFlowId { get; set; }
        public string SourceDataUrl { get; set; }
        public ProductFlowInstanceContext Context { get; set; } = new ProductFlowInstanceContext();
        public ProductFlowInstanceMetadata Metadata { get; set; } = new ProductFlowInstanceMetadata();
    }
}
