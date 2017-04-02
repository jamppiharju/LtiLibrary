﻿namespace LtiLibrary.NetCore.Lti2
{
    public class ProductTechnicalDescription : LocalizedText
    {
        public ProductTechnicalDescription(string description)
        {
            Key = "product.technicalDescription";
            Value = description;
        }
    }
}
