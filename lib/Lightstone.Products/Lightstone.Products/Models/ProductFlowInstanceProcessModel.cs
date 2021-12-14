namespace Lightstone.Products.Models
{
    public class ProductFlowInstanceProcessModel<TData> : ProductFlowInstanceModelBase
    {
        public ProductFlowInstanceInput<TData> Input { get; set; }
        public string CallbackUrlForDataUpdates { get; set; }
    }
}
