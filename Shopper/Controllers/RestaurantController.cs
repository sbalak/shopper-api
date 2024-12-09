﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopper.Infrastructure;

namespace Shopper.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _restaurant;

        public RestaurantController(IRestaurantService restaurant) 
        {
            _restaurant = restaurant;
        }

        [HttpGet("List")]
        public async Task<List<RestaurantModel>> List(double latitude, double longitude, string? query = "", int? page = 1, int? pageSize = 10)
        {
            var restaurants = await _restaurant.GetRestaurants(latitude, longitude, query, page, pageSize);
            return restaurants;
        }

        [HttpGet("RecentlyVisited")]
        public async Task<List<RestaurantRecentlyVisitedModel>> RecentlyVisited(double latitude, double longitude, int? page = 1, int? pageSize = 10)
        {
            var restaurants = await _restaurant.GetRestaurantsRecentlyVisited(latitude, longitude, page, pageSize);
            return restaurants;
        }

        [HttpGet("Details")]
        public async Task<RestaurantModel> Details(int restaurantId)
        {
            var restaurant = await _restaurant.GetRestaurant(restaurantId);
            return restaurant;
        }

        [HttpGet("FoodItems")]
        public async Task<List<CategorizedFoodItemModel>> FoodItems(int userId, int restaurantId, string? searchText = null)
        {
            var foodItems = await _restaurant.GetFoodItems(userId, restaurantId, searchText);
            return foodItems;
        }
    }
}
