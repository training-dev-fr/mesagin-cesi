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
        public ActionResult Register(UserModel user)
        {
            Console.WriteLine("Register");
            Console.WriteLine(user.ToString());
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
