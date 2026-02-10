using LightstonePlatform.Products.Enums;
using System;

namespace LightstonePlatform.Products.Models
{
    public class ProductFlowInstanceErrorInputModel
    {
        public Guid ProductFlowId { get; set; }
        public ProductFlowInstanceStatus Status { get; set; }
    }
}
