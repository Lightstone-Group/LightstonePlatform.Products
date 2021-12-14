using LightstonePlatform.Products.Enums;

namespace LightstonePlatform.Products.Models
{
    public class ContinueStartResponse : StartResponse
    {
        public override ResponseType Type { get => ResponseType.Continue; set => base.Type = value; }

        public object Input { get; set; }
    }
}
