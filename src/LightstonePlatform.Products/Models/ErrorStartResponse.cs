using LightstonePlatform.Products.Enums;
using System;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class ErrorStartResponse : StartResponse
    {
        public override ResponseType Type { get => ResponseType.Error; set => base.Type = value; }

        public string Error { get; set; }
    }
}
