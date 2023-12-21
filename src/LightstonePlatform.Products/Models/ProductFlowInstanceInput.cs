using System;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class ProductFlowInstanceInput<TData>: ProductFlowInstanceBase
    {

        public ProductFlowInstanceInput()
        {

        }
        public TData Data { get; set; }
    }
}
