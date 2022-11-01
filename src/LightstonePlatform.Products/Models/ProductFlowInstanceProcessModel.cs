using System.Xml.Linq;

namespace LightstonePlatform.Products.Models
{
    //public class ProductFlowInstanceProcessModel<TData> : ProductFlowInstanceBase
    //{
    //    public ProductFlowInstanceInput<TData> Input { get; set; }
    //    public string CallbackUrlForDataUpdates { get; set; }
    //    public string ProcessFailureRefundUrl { get; set; }
    //}

    public class ProductFlowInstanceProcessModel<TData> : ProductFlowInstanceBase
    {
        public ProductFlowInstanceInput<TData> Input { get; set; }
        public string CallbackUrlForDataUpdates { get; set; }
        public string ProcessFailureRefundUrl { get; set; }
    }
}
