using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequestandResponseAssignment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public void Index(int a)
        {
            Response.Write(Factorial(a));
        }

        private int Factorial(int a)
        {
            int factorialValue = 1;
            for(int i = a; i > 0; i--)
            {
                factorialValue *= i;
            }
            return factorialValue;
        }
    }
}