using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sendme.Models;

namespace sendme.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : Controller
    {
        private static List<MessageModel> listMessage = new List<MessageModel>();
        [HttpPost]
        public ActionResult Create(MessageModel message)
        {
            listMessage.Add(message);
            return Ok(message);
        }

        public ActionResult GetAll()
        {
            var listOrderMessage = listMessage.OrderBy(m => m.createdAt);
            return Ok(listOrderMessage);
        }
        
    }
}
