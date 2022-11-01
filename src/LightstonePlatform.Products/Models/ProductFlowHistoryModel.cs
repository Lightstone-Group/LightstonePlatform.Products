using LightstonePlatform.Products.Enums;
using Newtonsoft.Json;
using System;

namespace LightstonePlatform.Products.Models
{
    public class ProductFlowHistoryModel
    {
        [JsonProperty("id")]
        public string ProductFlowId { get; set; }
        public string PartyId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public ProductFlowInstanceStatus Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime? ExpiryTimestamp { get; set; }
    }
}
