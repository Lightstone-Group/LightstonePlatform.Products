using System;
using System.Collections.Generic;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class UiBase
    {
        public Dictionary<string, string> Attributes { get; set; }

        public string ElementName { get; set; }

        public string ElementUrl { get; set; }
    }
}