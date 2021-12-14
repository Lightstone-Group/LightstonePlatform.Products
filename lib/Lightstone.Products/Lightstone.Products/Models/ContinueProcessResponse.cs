using Lightstone.Products.Enums;

namespace Lightstone.Products.Models
{
    public class ContinueProcessResponse : ProcessResponse
    {
        public override ResponseType Type { get => ResponseType.Continue; set => base.Type = value; }
    }
}
