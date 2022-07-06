using System;

namespace LightstonePlatform.Products.Models
{
    public class QuoteLineItemDisplayModel
    {
        public string Description
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }

        public string ProductCode
        {
            get;
            set;
        }

        public string ProductName
        {
            get;
            set;
        }

        public Guid? UniqueReference
        {
            get;
            set;
        }

        public Guid? ContractId
        {
            get;
            set;
        }

        public Guid AccountId
        {
            get;
            set;
        }

        public Guid? PaymentMethodId
        {
            get;
            set;
        }
    }
}
