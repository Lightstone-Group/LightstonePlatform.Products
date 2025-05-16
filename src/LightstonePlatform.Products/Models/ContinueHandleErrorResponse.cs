using LightstonePlatform.Products.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class ContinueHandleErrorResponse : HandleErrorResponse
    {
        public override ResponseType Type { get => ResponseType.Continue; set => base.Type = value; }
    }
}
