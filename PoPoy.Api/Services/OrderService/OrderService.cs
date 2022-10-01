﻿using Microsoft.EntityFrameworkCore;
using PoPoy.Api.Data;
using PoPoy.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoPoy.Api.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _context;
        public OrderService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetAllOrders()
        {
            var query = from o in _context.Orders
                        select new { o };

            var orderDetails = await _context.OrderDetails.Join(_context.Orders,
                                                          od => od.OrderIdFromOrder,
                                                          o => o.Id,
                                                          (od, o) => od ).ToListAsync();

            return await query.Select(x => new Order()
            {
                Id = x.o.Id,
                UserId = x.o.UserId,
                AddressId = x.o.AddressId,
                OrderDate = x.o.OrderDate,
                TotalPrice = x.o.TotalPrice,
                PaymentMode = x.o.PaymentMode,
                OrderStatus = x.o.OrderStatus,
                OrderDetails = orderDetails
            }).ToListAsync();
        }

        public async Task<List<OrderDetails>> GetOrderDetails(string orderId)
        {
            var orderDetails = await(from od in _context.OrderDetails
                                     join o in _context.Orders on od.OrderIdFromOrder equals o.Id
                                     where od.OrderIdFromOrder == orderId
                                     select od).ToListAsync();

            return orderDetails;
        }

        public async Task<List<Order>> SearchOrder(string searchText)
        {
            var query = from o in _context.Orders
                        where o.UserId.ToString().ToLower().Contains(searchText.ToLower()) ||
                        o.Id.ToLower().Contains(searchText.ToLower())
                        select new { o };

            return await query.Select(x => new Order()
            {
                Id = x.o.Id,
                UserId = x.o.UserId,
                AddressId = x.o.AddressId,
                OrderDate = x.o.OrderDate,
                TotalPrice = x.o.TotalPrice,
                PaymentMode = x.o.PaymentMode,
                OrderStatus = x.o.OrderStatus
            }).ToListAsync();
        }

        public async Task<int> DeleteOrder(string orderId)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == orderId);
            var orderDetails = await (from od in _context.OrderDetails
                                      join o in _context.Orders on od.OrderIdFromOrder equals o.Id
                                      where od.OrderIdFromOrder == orderId
                                      select od).ToListAsync();
            foreach (var item in orderDetails)
            {
                _context.OrderDetails.Remove(item);
            }
            _context.Orders.Remove(order);

            return await _context.SaveChangesAsync();
        }
    }
}