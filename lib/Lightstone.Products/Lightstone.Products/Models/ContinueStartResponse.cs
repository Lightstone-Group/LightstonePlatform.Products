using Lightstone.Products.Enums;

namespace Lightstone.Products.Models
{
    public class ContinueStartResponse : StartResponse
    {
        public override ResponseType Type { get => ResponseType.Continue; set => base.Type = value; }

        public object Input { get; set; }
    }
}
