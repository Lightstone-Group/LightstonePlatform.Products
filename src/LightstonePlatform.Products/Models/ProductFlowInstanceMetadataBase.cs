using Lightstone.Quote.Shared.Models;

namespace LightstonePlatform.Products.Models
{
    public class ProductFlowInstanceMetadataBase
    {
        public string Source { get; set; }
        public QuoteDisplayModel Quote { get; set; }
        public string AdditionalConfiguration { get; set; }
    }
}
