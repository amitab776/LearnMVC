using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ContentResult Add(int a, int b)
        {
            return new ContentResult { Content = (a+b).ToString() };
        }

        public ContentResult Square(int number)
        {
            return new ContentResult { Content = (number* number).ToString() };
        }
    }
}