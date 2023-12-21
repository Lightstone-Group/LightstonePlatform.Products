using LightstonePlatform.Products.Enums;
using System;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class ProductFlowInstance<T> : ProductFlowInstanceBase
    { 
        public string PartyId { get; set; }
        public string TenantId { get; set; }
        public string ReferenceFlow { get; set; }
        public ProductFlowInstanceInput<T> Input { get; set; } = new ProductFlowInstanceInput<T>();
        public ProductFlowInstanceOutput Output { get; set; } = new ProductFlowInstanceOutput();
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public ProductFlowInstanceStatus Status { get; set; } = ProductFlowInstanceStatus.New;
        public DateTimeOffset CreatedTimestamp { get; set; } = DateTime.UtcNow;
        public DateTimeOffset? ExpiryTimestamp { get; set; }
        public string Version { get; set; }
        public bool PopupOnly { get; set; }
        public int InputsHash { get; set; }
        public int ContextHash { get; set; }
        public bool IsUserPresent { get; set; } = true;
    }  
}