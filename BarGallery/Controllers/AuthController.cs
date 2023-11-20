using BGCommon.Helpers;
using BGCommon.Models.API;
using BGCommon.Models.API.Response.Auth;
using BGDataLayer.DAL.Interfaces;
using BGDataLayer.IdentityModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace BarGallery.Controllers
{
    public class AuthController : BaseController
    {
        public AuthController(IUnitOfWork unitOfWork, UserManager<User> userManager, SignInManager<User> signInManager, ILogger<AuthController> logger)
            : base(unitOfWork, userManager, signInManager, logger)
        {
        }

        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(typeof(AuthResponseModel),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UnauthorizedResponseModel),StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Authenticate(AuthRequestModel requestModel)
        {
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, requestModel.Username) };

            JwtSecurityToken jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    claims: claims,
                    expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            
            string token = new JwtSecurityTokenHandler().WriteToken(jwt);

            AuthResponseModel responseModel = new AuthResponseModel
            {
                AccessToken = token,
                Username = requestModel.Username,
            };

            return Ok(responseModel);
        }

        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(typeof(AuthResponseModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UnauthorizedResponseModel), StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> RegisterUser()
        {
            return Ok();
        }


    }
}
