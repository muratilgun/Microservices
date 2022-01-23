using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FreeCourse.Shared.Dtos;
using FreeCourse.Shared.Services;
using FreeCourse.Web.Models.FakePayment;
using FreeCourse.Web.Models.Orders;
using FreeCourse.Web.Services.Interface;

namespace FreeCourse.Web.Services
{
    public class OrderService : IOrderService
    {
        private readonly IPaymentService _paymentService;
        private readonly HttpClient _httpClient;
        private readonly IBasketService _basketService;
        private readonly ISharedIdentityService _identityService;
        public OrderService(IPaymentService paymentService, HttpClient httpClient, IBasketService basketService, ISharedIdentityService identityService)
        {
            _paymentService = paymentService;
            _httpClient = httpClient;
            _basketService = basketService;
            _identityService = identityService;
        }

        public async Task<OrderCreatedViewModel> CreateOrder(CheckOutInfoInput checkOutInfoInput)
        {
            var basket = await _basketService.Get();
            var paymentInfoInput = new PaymentInfoInput()
            {
                CardName = checkOutInfoInput.CardName,
                CardNumber = checkOutInfoInput.CardNumber,
                Expiration = checkOutInfoInput.Expiration,
                CVV = checkOutInfoInput.CVV,
                TotalPrice = basket.TotalPrice
            };
            var responsePayment = await _paymentService.ReceivePayment(paymentInfoInput);
            if (!responsePayment)
            {
                return new OrderCreatedViewModel() { Error = "Ödeme Alınamadı.", IsSuccessful = false };
            }

            var orderCreateInput = new OrderCreateInput()
            {
                BuyerId = _identityService.GetUserId,
                Address = new AddressCreateInput { Province = checkOutInfoInput.Province, District = checkOutInfoInput.District, Street = checkOutInfoInput.Street, Line = checkOutInfoInput.Line, ZipCode = checkOutInfoInput.ZipCode }
            };
            basket.BasketItems.ForEach(x =>
            {
                var orderItem  = new OrderItemCreateInput{ProductId = x.CourseId,Price = x.GetCurrentPrice,PictureUrl = "",ProductName = x.CourseName};
                orderCreateInput.OrderItems.Add(orderItem);
            });

            var response = await _httpClient.PostAsJsonAsync<OrderCreateInput>("orders",orderCreateInput);
            if (!response.IsSuccessStatusCode)
            {
                return new OrderCreatedViewModel() { Error = "Sipariş oluşturulamadı.", IsSuccessful = false };
            }

            var orderCreatedViewModel =  await response.Content.ReadFromJsonAsync<Response<OrderCreatedViewModel>>();
            orderCreatedViewModel.Data.IsSuccessful = true;
            await _basketService.Delete();
            return orderCreatedViewModel.Data;
        }
        public async Task<List<OrderViewModel>> GetOrder()
        {
            var response = await _httpClient.GetFromJsonAsync<Response<List<OrderViewModel>>>("orders");
            return response.Data;
        }
        public async Task<OrderSuspendViewModel> SuspendOrder(CheckOutInfoInput checkOutInfoInput)
        {
            var basket = await _basketService.Get();

            var orderCreateInput = new OrderCreateInput()
            {
                BuyerId = _identityService.GetUserId,
                Address = new AddressCreateInput { Province = checkOutInfoInput.Province, District = checkOutInfoInput.District, Street = checkOutInfoInput.Street, Line = checkOutInfoInput.Line, ZipCode = checkOutInfoInput.ZipCode }
            };
            basket.BasketItems.ForEach(x =>
            {
                var orderItem = new OrderItemCreateInput { ProductId = x.CourseId, Price = x.GetCurrentPrice, PictureUrl = "", ProductName = x.CourseName };
                orderCreateInput.OrderItems.Add(orderItem);
            });
            var paymentInfoInput = new PaymentInfoInput()
            {
                CardName = checkOutInfoInput.CardName,
                CardNumber = checkOutInfoInput.CardNumber,
                Expiration = checkOutInfoInput.Expiration,
                CVV = checkOutInfoInput.CVV,
                TotalPrice = basket.TotalPrice,
                Order = orderCreateInput
            };

            var responsePayment = await _paymentService.ReceivePayment(paymentInfoInput);
            if (!responsePayment)
            {
                return new OrderSuspendViewModel() { Error = "Ödeme Alınamadı.", IsSuccessful = false };
            }

            await _basketService.Delete();
            return new OrderSuspendViewModel() { IsSuccessful = true };
        }

    }
}
