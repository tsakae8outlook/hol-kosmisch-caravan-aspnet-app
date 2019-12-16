//using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Areas.Admin.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Admin/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}