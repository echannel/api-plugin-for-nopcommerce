using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTOs.Discounts
{
    public class DiscountsRootObject : ISerializableObject
    {
        public DiscountsRootObject()
        {
            Discounts = new List<DiscountDto>();
        }

        [JsonProperty("discounts")]
        public IList<DiscountDto> Discounts { get; set; }

        public string GetPrimaryPropertyName()
        {
            return "discounts";
        }

        public Type GetPrimaryPropertyType()
        {
            return typeof(DiscountDto);
        }
    }
}
