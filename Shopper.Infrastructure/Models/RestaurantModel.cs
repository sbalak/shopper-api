﻿using Shopper.Data;

namespace Shopper.Infrastructure
{
    public class RestaurantModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Locality { get; set; }
        public string City { get; set; }
        public string Cuisine { get; set; }
        public double Distance { get; set; }
    }

    public class FoodItemModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string? Photo { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }

    public class CategorizedFoodItemModel
    {
        public CategorizedFoodItemModel()
        {
            Data = new List<FoodItemModel>();
        }

        public string Title { get; set; }
        public List<FoodItemModel> Data { get; set; }
    }
}