using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCRecipes.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld/
        //public string Index()
        //  {
        //    return "default action";
        //}

        //GET: /HelloWorld/Welcome/ basic route matching
        //public string Welcome()
        //  {
        //    return "welcome action";
        //  }

        // GET: /HelloWorld/Welcome?name=[]&times=[]/ action matched with query params
        // can't overload above method
        //public string Welcome(string name, int times)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, time = {times}");
        // }

        //GET: /{Controller}/{Action}/{id?}
        //public string Welcome(string name, int ID = 1)
        //  {
        //    return HtmlEncoder.Default.Encode($"Hello {name}, time = {ID}");
        //}

        //GET:  using a view (Razor View) instead of hardcoded string methods above
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int times = 1)
        {
            ViewData["Message"] = "Supp? " + name;
            ViewData["Times"] = times;

            return View();
        }
    }
}