using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrlRedirection.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("Bookstore")]
        public IActionResult Index()
        {
            // return new RedirectToActionResult("Index","Store", new { }); // return 302 result temporarily moved

            return new RedirectToActionResult("Index", "Store", new { }, permanent:true);  // return 301 result permentaly moved

        }
    }
}

