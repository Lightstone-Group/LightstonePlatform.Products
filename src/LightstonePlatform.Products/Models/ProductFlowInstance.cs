using LightstonePlatform.Products.Enums;
using System.Collections.Generic;
using System;
using Azure;
using Legal.Models;

namespace LightstonePlatform.Products.Models
{
    public class ProductFlowInstance<T> : ProductFlowInstanceBase
    { 
        public string Id { get; set; }
        public string PartyId { get; set; }
        public string TenantId { get; set; }
        public string ReferenceFlow { get; set; }
        public ProductFlowInstanceInput<T> Input { get; set; } = new ProductFlowInstanceInput<T>();
        public ProductFlowInstanceOutput Output { get; set; } = new ProductFlowInstanceOutput();
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public ProductFlowInstanceStatus Status { get; set; } = ProductFlowInstanceStatus.New;
        public DateTimeOffset CreatedTimestamp { get; set; } = DateTime.UtcNow;
        public DateTimeOffset? ExpiryTimestamp { get; set; }
        public ETag ETag { get; set; }
        public string Version { get; set; }
        public bool PopupOnly { get; set; }
        public ProceedLegalModel LegalData { get; set; }
        public ProceedTermsModel ProductTermsData { get; set; }
        public int InputsHash { get; set; }
        public int ContextHash { get; set; }
        public bool IsUserPresent { get; set; } = true;

        public void SetActiveUI(string elementUrl, string elementName, Dictionary<string, string> attributes, bool addToHistory = false)
        {
            if (Metadata?.UI?.Active != null && Metadata?.UI?.Active?.AddToHistory == true)
                Metadata.UI.History.Add(Metadata.UI.Active);
            if (Metadata == null)
                Metadata = new ProductFlowInstanceMetadata();
            Metadata.UI.Active = new UI(elementUrl, elementName, attributes, addToHistory);
        }

        public bool HasGrounds()
        {
            if (LegalData == null) return false;

            return LegalData.ConcentFromDataSubject || LegalData.HasContract || LegalData.RequirementByLaw || LegalData.PublicLawDuty || LegalData.InInterestOfDataSubject || LegalData.InInterestOfThirdParty;
        }



    }  
}