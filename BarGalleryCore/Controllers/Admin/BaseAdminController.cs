using AdaptiveStoreAdmin.Controllers;
using BGDataLayer.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BarGalleryCore.Controllers.Admin
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize(AuthenticationSchemes = "Bearer",Roles = "ADMIN")]
    public class BaseAdminController : ControllerBase
    {
        protected readonly ILogger<BaseController> _logger;
        protected UserManager<User> _userManager;
        protected SignInManager<User> _signInManager;
        public BaseAdminController(UserManager<User> userManager, SignInManager<User> signInManager, ILogger<BaseController> logger = null)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
        }
    }
}
