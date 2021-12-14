using LightstonePlatform.Products.Enums;

namespace LightstonePlatform.Products.Models
{
    public class StartResponse
    {
        public virtual ResponseType Type { get; set; }
        public string ProductDescription { get; set; }
    }
}
