﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeCourse.Services.Order.Domain.Core;

namespace FreeCourse.Services.Order.Domain.OrderAggregate
{
    //EF Core feature
    // -Owned Types
    // -Shadow Propery
    // -Backing Field
    public class Order : Entity,IAggregateRoot
    {
        public DateTime CreatDateTime { get; private set; }
        public Address Address { get; private set; }
        public string BuyerId { get; private set; }
        private readonly List<OrderItem> _orderItems;

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;
        public Order(string buyerId,Address address)
        {
            _orderItems = new List<OrderItem>();
            CreatDateTime = DateTime.Now;
            BuyerId = buyerId;
            Address = address;

        }

        public void AddOrderItem(string productId, string productName, decimal price, string pictureUrl)
        {
            var existProduct = _orderItems.Any(x => x.ProductId == productId);
            if (!existProduct)
            {
                var newOrderItem = new OrderItem(productId, productName, pictureUrl, price);
                _orderItems.Add(newOrderItem);
            }
        }

        public decimal GetTotalPrice => _orderItems.Sum(x => x.Price);
    }
}
