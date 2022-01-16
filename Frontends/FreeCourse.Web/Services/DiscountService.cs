using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Models.Discounts;
using FreeCourse.Web.Services.Interface;

namespace FreeCourse.Web.Services
{
    public class DiscountService : IDiscountService
    {
        public async Task<DiscountViewModel> GetDiscount(string discountCode)
        {
            throw new NotImplementedException();
        }

    }
}
