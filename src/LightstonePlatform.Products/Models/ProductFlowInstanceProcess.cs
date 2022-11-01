using System.Xml.Linq;

namespace LightstonePlatform.Products.Models
{
    public class ProductFlowInstanceProcess<TData> : ProductFlowInstanceBase
    {
        public ProductFlowInstanceInput<TData> Input { get; set; }
        public string CallbackUrlForDataUpdates { get; set; }
        public string ProcessFailureRefundUrl { get; set; }
    }
}
