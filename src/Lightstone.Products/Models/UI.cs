using System;
using System.Collections.Generic;

namespace Lightstone.Products.Models
{
    public class UI
    {

        public UI()
        {

        }
        public UI(string elementUrl, string elementName, Dictionary<string, string> attributes, bool addToHistory)
        {
            ElementUrl = elementUrl;
            ElementName = elementName;
            Attributes = attributes;
            AddToHistory = addToHistory;
        }

        public string ElementUrl { get; set; }
        public string ElementName { get; set; }
        public Dictionary<string, string> Attributes { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public bool AddToHistory { get; set; }
    }
}
