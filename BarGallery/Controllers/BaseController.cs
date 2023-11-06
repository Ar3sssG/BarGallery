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

        public BaseController() 
        {

        }
    }
}
