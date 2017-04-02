﻿namespace LtiLibrary.NetCore.Lti2
{
    public class ProductName : LocalizedName
    {
        public ProductName(string name)
        {
            Key = "product.name";
            Value = name;
        }
    }
}
