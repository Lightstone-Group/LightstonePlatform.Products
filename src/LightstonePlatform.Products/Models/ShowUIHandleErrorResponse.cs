using LightstonePlatform.Products.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class ShowUIHandleErrorResponse : HandleErrorResponse
    {
        public override ResponseType Type { get => ResponseType.ShowUI; set => base.Type = value; }
        public string ElementUrl { get; set; }
        public string ElementName { get; set; }
        public Dictionary<string, string> Attributes { get; set; }
        public object Body { get; set; }
    }
}
