using System.Xml.Linq;

namespace LightstonePlatform.Products.Models
{
    public class ProductFlowInstanceProcess<TData> : ProductFlowInstance<TData>
    {
        public string CallbackUrlForDataUpdates { get; set; }
        public string ProcessFailureRefundUrl { get; set; }
    }
}
