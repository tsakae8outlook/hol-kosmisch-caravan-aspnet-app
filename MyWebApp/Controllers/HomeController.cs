using MyWebApp.Models;
//using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Message = Session["message"]?.ToString() ?? "";
            //return View();
            string message = HttpContext.Session.GetString("message");
            return View(new MyForm { Message = message});
        }

        [HttpPost]
        public ActionResult Index(MyForm item)
        {
            // if (!string.IsNullOrWhiteSpace(item?.Message))
            // {
            //     Session["message"] = item.Message;
            // }
            HttpContext.Session.SetString("message",item.Message);
            return RedirectToAction("Index");
        }
    }
}