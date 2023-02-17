using LightstonePlatform.Products.Enums;

namespace LightstonePlatform.Products.Models
{
    public class ErrorStartResponse : StartResponse
    {
        public override ResponseType Type { get => ResponseType.Error; set => base.Type = value; }

        public string Error { get; set; }
    }
}
