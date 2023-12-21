using LightstonePlatform.Products.Enums;
using System;

namespace LightstonePlatform.Products.Models
{
    [Serializable]
    public class ContinueProcessResponse : ProcessResponse
    {
        public override ResponseType Type { get => ResponseType.Continue; set => base.Type = value; }
    }
}
