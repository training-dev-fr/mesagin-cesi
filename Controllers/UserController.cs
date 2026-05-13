using Microsoft.AspNetCore.Mvc;
using sendme.Models;

namespace sendme.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private List<UserModel> listUser = new List<UserModel>();

        [HttpPost]
        [Route("register")]
        public ActionResult Register()
        {
            Console.WriteLine("Register");
            return Ok();
        }

        [HttpPost]
        [Route("login")]
        public ActionResult Login()
        {
            Console.WriteLine("Login");
            return Ok();
        }
    }
}
