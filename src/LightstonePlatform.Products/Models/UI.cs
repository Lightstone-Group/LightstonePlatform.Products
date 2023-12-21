using System;
using System.Collections.Generic;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class UI : UiBase
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

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public bool AddToHistory { get; set; }
    }
}
