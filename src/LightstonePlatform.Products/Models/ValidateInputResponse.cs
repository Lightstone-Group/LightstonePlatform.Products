using System;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class ValidateInputResponse
    {
        public bool Succesful { get; set; }
        public string ProductDesctiption { get; set; }
    }
}
