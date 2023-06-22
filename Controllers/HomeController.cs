using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlRedirection.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrlRedirection.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("Bookstore/{bookid?}/{isloggedIn?}")]

        public IActionResult Index([FromRoute]int? bookid, [FromRoute ]bool? isloggedIn,
             Book book)
        {
            // return new RedirectToActionResult("Index","Store", new { }); // return 302 result temporarily moved

            // return new RedirectToActionResult("Index", "Store", new { }, permanent:true);  // return 301 result permentaly moved

            return Content("Route parameter Example"); 
        }
    }
}

