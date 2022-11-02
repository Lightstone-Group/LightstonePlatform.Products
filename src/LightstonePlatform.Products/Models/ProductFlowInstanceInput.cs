namespace LightstonePlatform.Products.Models
{
    public class ProductFlowInstanceInput<TData>: ProductFlowInstanceBase
    {

        public ProductFlowInstanceInput()
        {

        }
        public TData Data { get; set; }
    }
}
