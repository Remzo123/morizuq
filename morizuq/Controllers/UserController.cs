using Microsoft.AspNetCore.Mvc;
using morizuq.DTO.RequestModel;
using morizuq.Implementation.Interface;

namespace morizuq.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> createUser(CreateUser request)
        {
            var user = await _user.Createuser(request);
            if (user.Success == false)
            {
                return View(user);
            }
            return View(user);
        }
    }
}
