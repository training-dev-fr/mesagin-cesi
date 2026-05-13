using Microsoft.AspNetCore.Mvc;
using sendme.Models;

namespace sendme.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private static List<UserModel> listUser = new List<UserModel>();

        [HttpPost]
        [Route("register")]
        public ActionResult Register(UserModel user)
        {
            UserModel? userFound = listUser.FirstOrDefault(u => u.Email == user.Email);
            if(userFound != null)
            {
                return Conflict("User already exists");
            }
            listUser.Add(user);
            return Created("",user);
        }

        [HttpPost]
        [Route("login")]
        public ActionResult Login(UserModel user)
        {
            UserModel? userFound = listUser.FirstOrDefault(u => u.Email == user.Email);
            if(userFound == null)
            {
                return Unauthorized();
            }
            if(userFound.Password != user.Password)
            {
                return Unauthorized();
            }
            return Ok("connected");

        }
    }
}
