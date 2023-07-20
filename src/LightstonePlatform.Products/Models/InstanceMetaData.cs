using System;
using System.Collections.Generic;
using System.Text;

namespace LightstonePlatform.Products.Models
{
    public class InstanceMetadata : ProductFlowInstanceMetadata
    {
        public Lightstone.Quote.Shared.Models.QuoteDisplayModel Quote { get; set; }
        public Lightstone.Capabilities.CollectFunds.Dto.PaymentData PaymentData { get; set; }
        public string Source { get; set; }
    }
}
