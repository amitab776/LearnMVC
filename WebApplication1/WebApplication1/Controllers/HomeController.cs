using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return Content("No input recieved");
            }
            switch (id.ToLower())
            {
                case "sample.pdf":
                    return File("~/sample.pdf", "application/pdf");
                case "gotoabout":
                    return RedirectToAction("About");
                case "login":
                    return View();
            }
            return Content("You Entered : " + id);
        }

        public ActionResult About()
        {
            return Content("About content here");
        }
    }
}