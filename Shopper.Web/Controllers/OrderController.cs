﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopper.Infrastructure;

namespace Shopper.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private IOrderService _order;

        public OrderController(IOrderService order)
        {
            _order = order;
        }

        [HttpGet("List")]
        public async Task<List<OrderModel>> List(int userId, int? page = 1, int? pageSize = 10)
        {
            var orders = await _order.GetOrders(userId, page, pageSize);
            return orders;
        }

        [HttpGet("Details")]
        public async Task<OrderModel> Details(int id)
        {
            var order = await _order.GetOrder(id);
            return order;
        }

        [HttpGet("Confirm")]
        public async Task Confirm(int userId)
        {
            await _order.Confirm(userId);
        }
    }
}
