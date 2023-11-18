using BGDataLayer.DAL.Interfaces;
using BGDataLayer.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BarGallery.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController : ControllerBase
    {
        protected readonly ILogger<BaseController> _logger;
        protected IUnitOfWork _unitOfWork;
        protected UserManager<User> _userManager;
        protected SignInManager<User> _signInManager;
        public BaseController(IUnitOfWork unitOfWork, UserManager<User> userManager, SignInManager<User> signInManager, ILogger<BaseController> logger = null)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }
    }
}
