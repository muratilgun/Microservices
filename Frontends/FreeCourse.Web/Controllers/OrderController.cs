using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Models.Orders;
using FreeCourse.Web.Services.Interface;

namespace FreeCourse.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IBasketService _basketService;
        private readonly IOrderService _orderService;

        public OrderController(IBasketService basketService, IOrderService orderService)
        {
            _basketService = basketService;
            _orderService = orderService;
        }

        public async Task<IActionResult> Checkout()
        {
            var basket = await _basketService.Get();
            ViewBag.basket = basket;

            return View(new CheckOutInfoInput());
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(CheckOutInfoInput checkOutInfoInput)
        {

            #region 1.yol sekron iletişim
            //var orderStatus = await _orderService.CreateOrder(checkOutInfoInput);
            //if (!orderStatus.IsSuccessful)
            //{
            //    var basket = await _basketService.Get();
            //    ViewBag.basket = basket;
            //    ViewBag.error = orderStatus.Error;
            //    return View();
            //}

            //return RedirectToAction(nameof(SuccessfulChekcout), new { orderId = orderStatus.OrderId }); 
            #endregion


            #region 2. yol asekron iletişim
            //2. yol asekron iletişim
            var orderSuspend = await _orderService.SuspendOrder(checkOutInfoInput);
            if (!orderSuspend.IsSuccessful)
            {
                var basket = await _basketService.Get();
                ViewBag.basket = basket;
                ViewBag.error = orderSuspend.Error;
                return View();
            }
            // suspende sadece true /false dönüyorum şuanda yapıyı değiştirmemek adına burada random değer dönüp test ediyorum
            return RedirectToAction(nameof(SuccessfulChekcout), new { orderId = new Random().Next(1,1000)});
            #endregion
        }

        public IActionResult SuccessfulChekcout(int orderId)
        {
            ViewBag.orderId = orderId;
            return View();
        }
        public async Task<IActionResult> CheckoutHistory()
        {
            return View(await _orderService.GetOrder());
        }
    }
}
