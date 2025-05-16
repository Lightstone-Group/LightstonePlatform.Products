using LightstonePlatform.Products.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class HandleErrorResponse
    {
        public virtual ResponseType Type { get; set; }
        public string ProductDescription { get; set; }
    }
}
