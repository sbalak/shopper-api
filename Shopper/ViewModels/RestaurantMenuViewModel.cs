﻿namespace Shopper.ViewModels
{
    public class RestaurantMenuViewModel
    {
        public RestaurantMenuViewModel()
        {
            FoodItems = new List<RestaurantMenuFoodViewModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string LegalName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Locality { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Cuisine { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public List<RestaurantMenuFoodViewModel> FoodItems { get; set; }
    }
    
    public class RestaurantMenuFoodViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
