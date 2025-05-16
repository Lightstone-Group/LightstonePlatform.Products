using LightstonePlatform.Products.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightstonePlatform.Products.Models
{
    public class ProductFlowInstanceHandleErrorModel
    {
        public string AdditionalConfiguration { get; set; }
        public Guid TenantId { get; set; }
        public ProductFlowInstanceStatus ProductFlowInstanceStatus { get; set; }
    }
}
