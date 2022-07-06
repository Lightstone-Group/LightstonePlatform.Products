namespace LightstonePlatform.Products.Models
{
    public class ProductFlowInstanceProcessModel<TData> : ProductFlowInstanceModelBase
    {
        public ProductFlowInstanceInput<TData> Input { get; set; }
        public string CallbackUrlForDataUpdates { get; set; }
        public string ProcessFailureRefundUrl { get; set; }
    }
}
