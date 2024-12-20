﻿using Microsoft.AspNetCore.Authentication.BearerToken;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopper.Data;
using Shopper.Infrastructure;

namespace Shopper.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _auth;

        public AuthController(IAuthService auth)
        {
            _auth = auth;
        }

        [HttpPost("Login")]
        public async Task Login(string username)
        {
            await _auth.Login(username);
        }

        [HttpPost("Verify")]
        public async Task<AccessTokenModel> Verify(string username, string code)
        {
            return await _auth.Verify(username, code);
        }

        [HttpPost("Refresh")]
        public async Task<AccessTokenModel> Refresh(AccessTokenModel model)
        {
            return await _auth.Refresh(model);
        }
    }
}