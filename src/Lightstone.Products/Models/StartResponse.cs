using Lightstone.Products.Enums;

namespace Lightstone.Products.Models
{
    public class StartResponse
    {
        public virtual ResponseType Type { get; set; }
        public string ProductDescription { get; set; }
    }
}
