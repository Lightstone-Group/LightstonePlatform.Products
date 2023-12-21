using LightstonePlatform.Products.Enums;
using System;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class ProcessResponse
    {
        public virtual ResponseType Type { get; set; }
        public object AdditionalData { get; set; }
        public string ProductDescription { get; set; }
    }
}
