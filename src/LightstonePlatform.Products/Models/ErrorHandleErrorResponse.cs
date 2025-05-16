using LightstonePlatform.Products.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class ErrorHandleErrorResponse : HandleErrorResponse
    {
        public override ResponseType Type { get => ResponseType.Error; set => base.Type = value; }
        public string Error { get; set; }
    }
}
