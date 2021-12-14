using LightstonePlatform.Products.Enums;

namespace LightstonePlatform.Products.Models
{
    public class ContinueProcessResponse : ProcessResponse
    {
        public override ResponseType Type { get => ResponseType.Continue; set => base.Type = value; }
    }
}
