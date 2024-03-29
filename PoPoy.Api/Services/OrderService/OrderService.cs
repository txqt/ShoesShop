﻿using MailKit.Search;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PoPoy.Api.Data;
using PoPoy.Api.Services.AuthService;
using PoPoy.Shared.Dto;
using PoPoy.Shared.Entities;
using PoPoy.Shared.Entities.OrderDto;
using PoPoy.Shared.Enum;
using PoPoy.Shared.Paging;
using PoPoy.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoPoy.Api.Extensions;

using Google.Maps;
using Google.Maps.DistanceMatrix;
using Google.Maps.Direction;
using Google.Maps.Geocoding;
using static Google.Maps.DistanceMatrix.DistanceMatrixResponse;
using PoPoy.Api.Helpers;

namespace PoPoy.Api.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _context;
        private readonly IConfiguration configuration;
        private readonly IAuthService _authService;
        public OrderService(DataContext context, IAuthService authService, IConfiguration configuration)
        {
            _context = context;
            this.configuration = configuration;
        }
        public async Task<Order> FindOrderById(string id)
        {
            var order = await _context.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(oi => oi.Product)
                .ThenInclude(pi => pi.ProductImages)
                .OrderByDescending(o => o.OrderDate)
                .FirstOrDefaultAsync(o=> o.Id == id);
            return order;
        }
        public async Task<List<Order>> GetAllOrders()
        {
            var query = from o in _context.Orders
                        select new { o };

            var orderDetails = await _context.OrderDetails.Join(_context.Orders,
                                                          od => od.OrderIdFromOrder,
                                                          o => o.Id,
                                                          (od, o) => od).ToListAsync();

            return await query.Select(x => new Order()
            {
                Id = x.o.Id,
                UserId = x.o.UserId,
                AddressId = x.o.AddressId,
                OrderDate = x.o.OrderDate,
                TotalPrice = x.o.TotalPrice,
                PaymentMode = x.o.PaymentMode,
                PaymentStatus = x.o.PaymentStatus,
                OrderStatus = x.o.OrderStatus,
                OrderDetails = orderDetails
            }).OrderByDescending(p => p.OrderDate).ToListAsync();
        }

        public async Task<List<OrderDetails>> GetOrderDetails(string orderId)
        {
            var orderDetails = await (from od in _context.OrderDetails
                                      join o in _context.Orders on od.OrderIdFromOrder equals o.Id
                                      where od.OrderIdFromOrder == orderId
                                      select od).ToListAsync();

            return orderDetails;
        }
        public async Task<Order> GetOrderWithUser(string orderId)
        {
            var orderDetails = await _context.Orders.Include(p => p.OrderDetails).ThenInclude(p=>p.Product).ThenInclude(p => p.ProductImages)
                .Include(p => p.User).Include(p => p.Address).Include(p=>p.Shipper).Include(x=>x.Refund).Where(p => p.Id == orderId).FirstOrDefaultAsync(); 

            return orderDetails;
        }

        public async Task<bool> AssignShipper(AssignShipperDto model)
        {
            if (model.ShipperId != Guid.Empty && !string.IsNullOrEmpty(model.OrderId))
            {
                var order = await _context.Orders.FindAsync(model.OrderId);
                order.ShipperId = model.ShipperId;
                order.OrderStatus = Shared.Enum.OrderStatus.Confirmed;
                 _context.Update(order);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;

        }


        public async Task<List<Order>> GetOrderByShipper(OrderShipperSearchDto input)
        {
            var orderDetails = await _context.Orders.Include(p => p.OrderDetails).ThenInclude(p => p.Product).ThenInclude(p => p.ProductImages)
                 .Include(p => p.User).Include(p => p.Address)
                 .Include(p => p.Shipper).Where(p => p.ShipperId == input.ShipperId && p.OrderStatus == input.Status).OrderByDescending(p => p.OrderDate).ToListAsync(); ;
            return orderDetails;

        }


        public async Task<bool> UpdateStatusOrder(UpdateStatusOrderDto input)
        {
            var order = await _context.Orders.FindAsync(input.OrderId);
            if (order != null)
            {
                order.OrderStatus = input.OrderStatus;
                _context.Update(order);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
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
            var refund = await _context.Refunds.FirstOrDefaultAsync(x => x.Order.Id == orderId);
            if (refund != null)
            {
                _context.Refunds.Remove(refund);
            }
            foreach (var item in orderDetails)
            {
                _context.OrderDetails.Remove(item);
            }
            _context.Orders.Remove(order);

            return await _context.SaveChangesAsync();
        }

        public async Task<PagedList<OrderOverviewResponse>> GetOrders(ProductParameters productParameters, Guid userId)
        {
            var orders = await _context.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(oi => oi.Product)
                .ThenInclude(pi => pi.ProductImages)
                .Where(o => o.UserId == userId)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();

            var orderResponse = new List<OrderOverviewResponse>();
            orders.ForEach(o => orderResponse.Add(new OrderOverviewResponse
            {
                Id = o.Id,
                OrderDate = o.OrderDate,
                TotalPrice = o.TotalPrice,
                Product = o.OrderDetails.Count > 1 ?
                    $"{o.OrderDetails.First().Product.Title} and" +
                    $" {o.OrderDetails.Count - 1} more..." :
                    o.OrderDetails.First().Product.Title,
                ProductImageUrl = o.OrderDetails.First().Product.ProductImages.FirstOrDefault()?.ImagePath != null
                ? o.OrderDetails.First().Product.ProductImages.FirstOrDefault()?.ImagePath : configuration["ApiUrl"] + "/uploads/no-photo-available.png",
                OrderStatus = o.OrderStatus,
                PaymentStatus = o.PaymentStatus,
                PaymentMode = o.PaymentMode
            }));
            orderResponse = orderResponse.AsQueryable().Search(productParameters.searchText).ToList();
            return PagedList<OrderOverviewResponse>.ToPagedList(orderResponse, productParameters.PageNumber, productParameters.PageSize);

        }

        public async Task<ServiceResponse<OrderDetailsResponse>> GetOrderDetailsForClient(string orderId)
        {
            var response = new ServiceResponse<OrderDetailsResponse>();
            var order = await _context.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(oi => oi.Product)
                .ThenInclude(oi => oi.ProductImages)
                .Include(o => o.OrderDetails)
                .Where(o => o.Id == orderId)
                .OrderByDescending(o => o.OrderDate)
                .FirstOrDefaultAsync();

            if (order == null)
            {
                response.Success = false;
                response.Message = "Order not found.";
                return response;
            }

            var orderDetailsResponse = new OrderDetailsResponse
            {
                OrderDate = order.OrderDate,
                TotalPrice = order.TotalPrice,
                Products = new List<OrderDetailsProductResponse>(),
                PaymentStatus = order.PaymentStatus,
                PaymentMode = order.PaymentMode,
                OrderStatus = order.OrderStatus
            };

            order.OrderDetails.ForEach(item =>
            orderDetailsResponse.Products.Add(new OrderDetailsProductResponse
            {
                OrderId = order.Id,
                ProductId = item.ProductId,
                ProductSize = item.SizeName,
                ProductImages = _context.ProductImages.Where(x => x.ProductId == item.ProductId).ToList().Count > 0 ?
                                _context.ProductImages.Where(x => x.ProductId == item.ProductId).ToList() : 
                                new List<ProductImage>() { new ProductImage() { ImagePath = configuration["ApiUrl"]+ "/uploads/no-photo-available.png" } },
                Quantity = item.Quantity,
                Title = item.Product.Title,
                TotalPrice = (decimal)item.TotalPrice
            }));

            response.Data = orderDetailsResponse;

            return response;
        }

        public async Task<bool> HasOrderById(string id)
        {
            return await _context.Orders.AnyAsync(o => o.Id == id);
        }

        public async Task<Refund> CancelOrder(Order order)
        {
            var refund = new Refund
            {
                DateRefunded = AppExtensions.GetDateTimeNow(),
            };

            order.Refund = refund;
            order.OrderStatus = OrderStatus.Cancelled;

            await _context.SaveChangesAsync();
            return refund;
        }

        public async Task<List<Order>> OrderHistoryShipper(Guid userid)
        {
            var orderDetails = await _context.Orders.Include(p => p.OrderDetails).ThenInclude(p => p.Product).ThenInclude(p => p.ProductImages)
                 .Include(p => p.User).Include(p => p.Address)
                 .Include(p => p.Shipper).Where(p => p.ShipperId == userid).ToListAsync(); ;
            return orderDetails;
        }
        public async Task<bool> SavePaymentUrl(string orderId, string paymentUrl)
        {
            try
            {
                var order = _context.Orders.FirstOrDefault(x => x.Id == orderId);
                order.PaymentGateUrl = paymentUrl;
                _context.Orders.Update(order);
                var result = await _context.SaveChangesAsync();
                if (result == 1)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

   
        public async Task<DistanceDto> DrivingDistancebyAddress(string address)
        {
            var result = new DistanceDto();

            try
            {
                string apiKey = configuration["GoogleApi"] ?? "AIzaSyCycNLXn-67a8utz5YGtVfYHEf4Zn0_xvc";
                DistanceMatrixRequest request = new DistanceMatrixRequest();
                request.AddOrigin(new Location(configuration["LocationOrigin"] ?? "Ho chi minh, Vietnam"));
                request.AddDestination(new Location(address));
                request.TransitMode = TransitModes.rail;
                request.Language = "vi";
                GoogleSigned.AssignAllServices(new GoogleSigned(apiKey));

                var response = await new DistanceMatrixService().GetResponseAsync(request);
                if (response.Status == ServiceResponseStatus.Ok)
                {
                    var distance = response.Rows.FirstOrDefault().Elements.FirstOrDefault();
                    double price = (distance.distance.Value / 3000) * 3000;
                    result.Price = price;
                    result.Time = "1 ngày làm việc, thời gian giao hàng khoảng: " + distance.duration.Text;
                    result.Distance = distance.distance.Text;
                } 
            }
            catch (Exception e)
            {

                Console.WriteLine("loi khong lay duoc vi tri: " + e.Message);
            }
            return result;

        }

        //public async Task<bool> SavePaymentUrl(string orderId)
        //{
        //    try
        //    {
        //        var paymentUrl = "";
        //        var order = _context.Orders.FirstOrDefault(x => x.Id == orderId);
        //        if (order.PaymentMode == "PayPal")
        //        {
        //            paymentUrl = "https://www.sandbox.paypal.com/signin";
        //        }
        //        else if (order.PaymentMode == "VNPay")
        //        {
        //            paymentUrl = "https://sandbox.vnpayment.vn/paymentv2";
        //        }
        //        order.PaymentGateUrl = paymentUrl;
        //        _context.Orders.Update(order);
        //        var result = await _context.SaveChangesAsync();
        //        if (result == 1)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public async Task<string> GetPaymentUrl(string orderId)
        {
            try
            {
                var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == orderId);
                return order.PaymentGateUrl;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
