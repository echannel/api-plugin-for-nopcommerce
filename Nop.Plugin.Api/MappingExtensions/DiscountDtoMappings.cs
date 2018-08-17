using AutoMapper;
using Nop.Core.Domain.Discounts;
using Nop.Plugin.Api.DTOs.Discounts;

namespace Nop.Plugin.Api.MappingExtensions
{
    public static class DiscountDtoMappings
    {
        public static DiscountDto ToDto(this Discount discount)
        {
            return Mapper.DynamicMap<Discount, DiscountDto>(discount);
        }
    }
}
