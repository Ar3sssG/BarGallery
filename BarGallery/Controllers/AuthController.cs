using BGDataLayer.DAL.Interfaces;
using BGDataLayer.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace BarGallery.Controllers
{
    public class AuthController : BaseController
    {
        public AuthController(IUnitOfWork unitOfWork, UserManager<User> userManager, SignInManager<User> signInManager, ILogger<AuthController> logger)
            : base(unitOfWork, userManager, signInManager, logger)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Authenticate()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser()
        {
            return Ok();
        }
    }
}
