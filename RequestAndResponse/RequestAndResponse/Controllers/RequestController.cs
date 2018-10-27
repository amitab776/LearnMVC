using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequestAndResponse.Controllers
{
    public class RequestController : Controller
    {
        // GET: Request
        public string Index()
        {
            string request = "";
            request += "Url : " + Request.Url+"<br>";
            request += "Browser :"+ Request.Browser.Type + "<br>";
            request += "Application Path :"+ Request.ApplicationPath + "<br>";
            request += "Path : "+Request.Path + "<br>";
            request += "Http Method : "+Request.HttpMethod + "<br>";
            request += "Query String : "+ Request.QueryString["x"] + "<br>";
            request += "Headers : "+Request.Headers["User-Agent"] + "<br>";
            return request;
        }
    }
}