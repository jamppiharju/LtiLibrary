﻿namespace LtiLibrary.NetCore.Lti2
{
    public class ServiceOwnerName : LocalizedName
    {
        public ServiceOwnerName(string name)
        {
            Key = "service_owner.name";
            Value = name;
        }
    }
}
