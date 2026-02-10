using LightstonePlatform.Products.Enums;
using System;

namespace LightstonePlatform.Products.Models
{
    public class ProductFlowInstanceErrorInputModel
    {
        public string ProductFlowId { get; set; }
        public string PartyId { get; set; }
        public ProductFlowInstanceStatus Status { get; set; }
    }
}
