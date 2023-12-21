using System;
using System.Collections.Generic;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class UIMetaData
    {
        public UI Active { get; set; }

        public List<UI> History { get; set; } = new List<UI>();
    }
}
