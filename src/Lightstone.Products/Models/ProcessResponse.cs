using Lightstone.Products.Enums;

namespace Lightstone.Products.Models
{
    public class ProcessResponse
    {
        public virtual ResponseType Type { get; set; }
        public object AdditionalData { get; set; }
    }
}
