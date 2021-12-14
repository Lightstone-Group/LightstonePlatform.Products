using LightstonePlatform.Products.Enums;
using System.Collections.Generic;

namespace LightstonePlatform.Products.Models
{
    public class ShowUIProcessResponse : ProcessResponse
    {
        public override ResponseType Type { get => ResponseType.ShowUI; set => base.Type = value; }
        public string ElementUrl { get; set; }
        public string ElementName { get; set; }

        public Dictionary<string, string> Attributes { get; set; }
        public object Body { get; set; }
    }
}
