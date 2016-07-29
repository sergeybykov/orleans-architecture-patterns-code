﻿namespace Demo.SmartCache.GrainInterfaces
{
    public class CatalogItem
    {
        public string DisplayName { get; set; }
        public string SKU { get; set; }
        public string ShortDescription { get; set; }

        public override string ToString()
        {
            return $@"[SKU : {SKU}] [DisplayName : {DisplayName}]
    [ShortDescription: {ShortDescription}]";
        }
    }
}