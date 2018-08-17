using Nop.Core;
using Nop.Core.Domain.Directory;
using Nop.Core.Domain.Discounts;
using Nop.Plugin.Api.Attributes;
using Nop.Plugin.Api.DTOs.Discounts;
using Nop.Plugin.Api.JSON.ActionResults;
using Nop.Plugin.Api.MappingExtensions;
using Nop.Plugin.Api.Serializers;
using Nop.Services.Customers;
using Nop.Services.Directory;
using Nop.Services.Discounts;
using Nop.Services.Localization;
using Nop.Services.Logging;
using Nop.Services.Media;
using Nop.Services.Security;
using Nop.Services.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Nop.Plugin.Api.Helpers;

namespace Nop.Plugin.Api.Controllers
{
    [BearerTokenAuthorize]
    public class DiscountController : BaseApiController
    {
        private IStoreContext _storeContext;
        private readonly IDTOHelper _dtoHelper;

        public DiscountController(IJsonFieldsSerializer jsonFieldsSerializer,
            IAclService aclService,
            ICustomerService customerService,
            IStoreMappingService storeMappingService,
            IStoreService storeService,
            IDiscountService discountService,
            ICustomerActivityService customerActivityService,
            ILocalizationService localizationService,
            IPictureService pictureService,
            IStoreContext storeContext,
            CurrencySettings currencySettings,
            ICurrencyService currencyService,
            ILanguageService languageService,
            IDTOHelper dtoHelper)
            : base(jsonFieldsSerializer,
                  aclService,
                  customerService,
                  storeMappingService,
                  storeService,
                  discountService,
                  customerActivityService,
                  localizationService,
                  pictureService)
        {
            _dtoHelper = dtoHelper;
        }


        /// <summary>
        /// Retrieve all discounts
        /// </summary>
        /// <param name="fields">Fields from the discount you want your json to contain</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [ResponseType(typeof(DiscountsRootObject))]
        [GetRequestsErrorInterceptorActionFilter]
        public IHttpActionResult GetAllDiscounts(string fields = "")
        {
            IList<Discount> allDiscounts = _discountService.GetAllDiscounts(null, showHidden: true);

            IList<DiscountDto> discountsAsDto = new List<DiscountDto>();

            foreach (var discount in allDiscounts)
            {
                var discountDto = _dtoHelper.PrepareDiscountDTO(discount);

                discountsAsDto.Add(discountDto);
            }

            var discountsRootObject = new DiscountsRootObject()
            {
                Discounts = discountsAsDto
            };

            var json = _jsonFieldsSerializer.Serialize(discountsRootObject, fields);

            return new RawJsonActionResult(json);
        }
    }
}
