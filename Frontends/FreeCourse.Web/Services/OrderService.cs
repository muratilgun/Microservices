using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FreeCourse.Web.Models.Orders;
using FreeCourse.Web.Services.Interface;

namespace FreeCourse.Web.Services
{
    public class OrderService : IOrderService
    {
        private readonly IPaymentService _paymentService;
        private readonly HttpClient _httpClient;
        private readonly IBasketService _basketService;
        public OrderService(IPaymentService paymentService, HttpClient httpClient, IBasketService basketService)
        {
            _paymentService = paymentService;
            _httpClient = httpClient;
            _basketService = basketService;
        }

        public async Task<OrderCreatedViewModel> CreateOrder(CheckOutInfoInput checkOutInfoInput)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderViewModel>> GetOrder()
        {
            throw new NotImplementedException();
        }
        public async Task SuspendOrder(CheckOutInfoInput checkOutInfoInput)
        {
            throw new NotImplementedException();
        }

    }
}
