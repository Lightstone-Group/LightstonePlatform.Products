using System;

namespace LightstonePlatform.Products.Models
{

    [Serializable]
    public class ProductFlowInstanceMetadata: ProductFlowInstanceMetadataBase
    {
        public UIMetaData UI { get; set; } = new UIMetaData();
    }
}
