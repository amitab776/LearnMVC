using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequestAndResponse.Controllers
{
    public class ResponseController : Controller
    {
        // GET: Response
        public void Index()
        {
            string response = "Response Object";
            Response.ContentType = "text/html";
            Response.StatusCode = 200;
            Response.Write(response);
        }
    }
}