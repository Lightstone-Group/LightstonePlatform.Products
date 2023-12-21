using LightstonePlatform.Products.Enums;
using System;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class StartResponse
    {
        public virtual ResponseType Type { get; set; }
        public string ProductDescription { get; set; }
    }
}
