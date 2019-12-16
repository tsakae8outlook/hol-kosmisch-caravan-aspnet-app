using MyWebApp.Models;
//using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDistributedCache cache;

        public HomeController(IDistributedCache cache)
        {
            this.cache = cache;
        }

        public ActionResult Index()
        {
            //ViewBag.Message = Session["message"]?.ToString() ?? "";
            //return View();
            //string message = HttpContext.Session.GetString("message");
            string message = cache.GetString("message");
            return View(new MyForm { Message = message});
        }

        [HttpPost]
        public IActionResult Index(MyForm item)
        {
            // if (!string.IsNullOrWhiteSpace(item?.Message))
            // {
            //     Session["message"] = item.Message;
            // }
            //HttpContext.Session.SetString("message",item.Message);
            cache.SetString("message",item.Message);
            return RedirectToAction("Index");
        }
    }
}