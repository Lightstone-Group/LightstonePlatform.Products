namespace LightstonePlatform.Products.Models
{
    public class ProductFlowInstanceInput<TData>: ProductFlowInstanceModelBase
    {

        public ProductFlowInstanceInput()
        {

        }
        public TData Data { get; set; }
    }
}
