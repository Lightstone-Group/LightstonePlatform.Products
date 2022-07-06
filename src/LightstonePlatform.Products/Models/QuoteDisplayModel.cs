using LightstonePlatform.Products.Models;
using System;
using System.Collections.Generic;

public class QuoteDisplayModel
{
    public Guid? UniqueReference
    {
        get;
        set;
    }

    public IEnumerable<QuoteLineItemDisplayModel> LineItems
    {
        get;
        set;
    }

    public decimal VAT
    {
        get;
        set;
    }

    public decimal Total
    {
        get;
        set;
    }

    public string Status
    {
        get;
        set;
    }
}