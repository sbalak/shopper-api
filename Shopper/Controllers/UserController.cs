﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopper.Data;
using Shopper.Infrastructure;

namespace Shopper.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private IUserService _user;

        public UserController(IUserService user)
        {
            _user = user;
        }

        [HttpGet("Id")]
        public async Task<int> Id(string email)
        {
            var userId = await _user.GetUserId(email);
            return userId;
        }

        [HttpGet("Details")]
        public async Task<User> Details(int userId)
        {
            var user = await _user.GetUser(userId);
            return user;
        }

        [HttpPost("Update")]
        public async Task<bool> Update(int userId, string firstName, string lastName)
        {
            await _user.Update(userId, firstName, lastName);
            return true;
        }

        [HttpGet("Coordinates")]
        public async Task<UserCoordinatesModel> Coordinates(int userId)
        {
            var coordinates = await _user.GetCoordinates(userId);
            return coordinates;
        }

        [HttpPost("SetCoordinates")]
        public async Task<bool> SetCoordinates(int userId, double latitude, double longitude)
        {
            await _user.SetCoordinates(userId, latitude, longitude);
            return true;
        }
    }
}
