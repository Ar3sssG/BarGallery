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
using System.Linq;

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
        [ProducesResponseType(typeof(AuthResponseModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UnauthorizedResponseModel), StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Authenticate(AuthRequestModel requestModel)
        {
            AuthResponseModel response = await AuthenticateUser(requestModel);
            return Ok(response);
        }

        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(typeof(AuthResponseModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UnauthorizedResponseModel), StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> RegisterUser(RegisterRequestModel requestModel)
        {
            User user = new User()
            {
                FirstName = requestModel.FirstName,
                LastName = requestModel.LastName,
                UserName = requestModel.Email,
                Email = requestModel.Email,
                RegisterDate = DateTime.Now,
                BirthDate = requestModel.BirthDate,
                NormalizedUserName = requestModel.Email.ToUpper(),
                NormalizedEmail = requestModel.Email.ToUpper(),
            };

            var result = await _userManager.CreateAsync(user, requestModel.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                AuthResponseModel response =  await AuthenticateUser(new AuthRequestModel());
                return Ok(response);
            }
            else
            {
                UnauthorizedResponseModel unauthorizedResponseModel = new UnauthorizedResponseModel
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    Message = string.Join("\n", result.Errors.Select(x => x.Description))
                };
            }
            return Ok();
        }

        [NonAction]
        private async Task<AuthResponseModel> AuthenticateUser(AuthRequestModel requestModel)
        {
            //TODO*************** LOGIN AND REGISTER FUNCTIONALITY
            //var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.Remember, false);
            //TODO************
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

            return new AuthResponseModel();
        }
    }
}
