﻿using CsvHelper.Configuration;

namespace GameShop.Application.Models.Tcg;

public class ModelClassMap : ClassMap<CsvImportModel>
{
#pragma warning disable IDE0058 // Expression value is never used
    public ModelClassMap()
    {
        //TODO remove this and make as json tags on obj model isntead
        Map(m => m.Quantity).Name("Quantity");
        Map(m => m.Name).Name("Name");
        Map(m => m.SimpleName).Name("Simple Name");
        Map(m => m.Set).Name("Set");
        Map(m => m.CardNumber).Name("Card Number");
        Map(m => m.SetCode).Name("Set Code");
        Map(m => m.Printing).Name("Printing");
        Map(m => m.Condition).Name("Condition");
        Map(m => m.Language).Name("Language");
        Map(m => m.Rarity).Name("Rarity");
        Map(m => m.ProductID).Name("Product ID");
        Map(m => m.SKU).Name("SKU");
    }
}