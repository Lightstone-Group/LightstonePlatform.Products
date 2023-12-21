using LightstonePlatform.Products.Enums;
using System;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class ContinueStartResponse : StartResponse
    {
        public override ResponseType Type { get => ResponseType.Continue; set => base.Type = value; }

        public object Input { get; set; }
    }
}
