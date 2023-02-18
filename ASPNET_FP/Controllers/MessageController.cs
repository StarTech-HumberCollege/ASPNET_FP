using ASPNET_FP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_FP.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            List<Message> messages = new List<Message>();
            DateTime dt = DateTime.Now;
            Message message1 = new Message(1, 1, 2, dt, "This is a first message");
            Message message2 = new Message(2, 1, 2, dt, "This is a second message");
            messages.Add(message1);
            messages.Add(message2);
            ViewBag.Messages = messages;
            return View(messages);
        }
        [Route("/Message/Details/{id:int}")]
        public IActionResult Details(int id)
        {
            List<Message> messages = new List<Message>();
            DateTime dt = DateTime.Now;
            Message message1 = new Message(1, 1, 2, dt, "This is a first message");
            Message message2 = new Message(2, 1, 2, dt, "This is a second message");
            messages.Add(message1);
            messages.Add(message2);

            return View(messages[id-1]);
        }
    }
}
