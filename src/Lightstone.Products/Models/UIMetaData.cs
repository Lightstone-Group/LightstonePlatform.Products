using System.Collections.Generic;

namespace Lightstone.Products.Models
{
    public class UIMetaData
    {
        public UI Active { get; set; }

        public List<UI> History { get; set; } = new List<UI>();
    }
}
