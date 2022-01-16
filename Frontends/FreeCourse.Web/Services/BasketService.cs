using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FreeCourse.Web.Models.Baskets;
using FreeCourse.Web.Services.Interface;

namespace FreeCourse.Web.Services
{
    public class BasketService : IBasketService
    {
        private readonly HttpClient _httpClient;

        public BasketService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> SaveOrUpdate(BasketViewModel basketViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<BasketViewModel> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete()
        {
            throw new NotImplementedException();
        }

        public async Task AddBasketItem(BasketItemViewModel basketItemViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RemoveBasketItem(string courseId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ApplyDiscount(string discountCode)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CancelApplyDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
