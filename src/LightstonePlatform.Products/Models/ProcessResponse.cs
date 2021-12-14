using LightstonePlatform.Products.Enums;

namespace LightstonePlatform.Products.Models
{
    public class ProcessResponse
    {
        public virtual ResponseType Type { get; set; }
        public object AdditionalData { get; set; }
    }
}
