﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoPoy.Api.Services.OrderService;
using PoPoy.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoPoy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetAllOrders()
        {
            var orders = await _orderService.GetAllOrders();
            return Ok(orders);
        }

        [HttpGet("orderDetails/{orderId}")]
        public async Task<ActionResult<List<Order>>> GetOrderDetails(string orderId)
        {
            var orderDetails = await _orderService.GetOrderDetails(orderId);
            return Ok(orderDetails);
        }

        [HttpGet("searchOrder/{searchText}")]
        public async Task<IActionResult> SearchProduct(string searchText)
        {
            var result = await _orderService.SearchOrder(searchText);
            if (result.Count == 0)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpDelete("{orderId}")]
        public async Task<IActionResult> DeleteProduct(string orderId)
        {
            var affectedResult = await _orderService.DeleteOrder(orderId);
            if (affectedResult == 0)
                return BadRequest();
            return Ok(affectedResult);
        }
    }
}