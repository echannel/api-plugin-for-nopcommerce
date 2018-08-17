using System;
using System.Collections.Generic;
using FluentValidation.Attributes;
using Newtonsoft.Json;
using Nop.Plugin.Api.Validators;

namespace Nop.Plugin.Api.DTOs.Discounts
{
    [JsonObject(Title = "discount")]
    public class DiscountDto
    {

        private List<int> _productIds;
        private List<int> _categoryIds;
        private List<string> _requirementTypes;

        /// <summary>
        /// Gets or sets the store ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the store name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the store URL
        /// </summary>
        [JsonProperty("use_percentage")]
        public bool? UsePercentage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether SSL is enabled
        /// </summary>
        [JsonProperty("discount_percentage")]
        public string DiscountPercentage { get; set; }

        /// <summary>
        /// Gets or sets the store secure URL (HTTPS)
        /// </summary>
        [JsonProperty("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// Gets or sets the comma separated list of possible HTTP_HOST values
        /// </summary>
        [JsonProperty("start_date_utc")]
        public DateTime? StartDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the default language for this store; 0 is set when we use the default language display order
        /// </summary>
        [JsonProperty("end_date_utc")]
        public DateTime? EndDateUtc { get; set; }

        
        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        [JsonProperty("requires_coupon_code")]
        public bool? RequiresCouponCode { get; set; }

        /// <summary>
        /// Gets or sets the company name
        /// </summary>
        [JsonProperty("coupon_code")]
        public string CouponCode { get; set; }

        /// <summary>
        /// Gets or sets the company address
        /// </summary>
        [JsonProperty("applied_to_sub_categories")]
        public bool? AppliedToSubCategories { get; set; }

        /// <summary>
        /// Gets or sets the discount type id
        /// </summary>
        [JsonProperty("discount_typeId")]
        public string DiscountTypeId { get; set; }

        /// <summary>
        /// Gets or sets the discount type
        /// </summary>
        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }


        /// <summary>
        /// Gets or sets the product ids in which the discount is applied
        /// </summary>
        [JsonProperty("product_ids")]
        public List<int> ProductIds
        {
            get
            {
                return _productIds;
            }
            set
            {
                _productIds = value;
            }
        }

        /// <summary>
        /// Gets or sets the category ids in which the discount is applied
        /// </summary>
        [JsonProperty("category_ids")]
        public List<int> CategoryIds
        {
            get
            {
                return _categoryIds;
            }
            set
            {
                _categoryIds = value;
            }
        }

        /// <summary>
        /// Gets or sets the requirement types in which the discount is applied
        /// </summary>
        [JsonProperty("requirement_types")]
        public List<string> RequirementTypes
        {
            get
            {
                return _requirementTypes;
            }
            set
            {
                _requirementTypes = value;
            }
        }
    }
}
