using LightstonePlatform.Products.Enums;

namespace LightstonePlatform.Products.Models
{
    public class ErrorProcessResponse : ProcessResponse
    {
        public override ResponseType Type { get => ResponseType.Error; set => base.Type = value; }
        public string Error { get; set; }
    }
}
