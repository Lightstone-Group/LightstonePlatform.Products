using System;
using System.Collections.Generic;
using System.Text;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class QuoteLineItemCaptureModel
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string ProductCode { get; set; }
        public Guid? UniqueReference { get; set; }
    }
}
