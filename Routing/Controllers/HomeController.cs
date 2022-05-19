using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Routing.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Routing.Controllers

{
    //    What are the different types of Routing supported by ASP.NET Core MVC?
    //In ASP.NET Core MVC application, you can define routes in two ways. They are as follows:

    //Convention Based Routing
    //Attribute-Based Routing.
    //What is Conventional Based Routing in ASP.NET Core MVC Application?
    //In Conventional Based Routing, the route is determined based on the conventions defined in the route templates which will map the incoming Requests (i.e.URLs) to controllers and their action methods.In ASP.NET Core MVC application, the Convention based Routes are defined within the Configure method of the Startup.cs class file.

    //What is Attribute-Based Routing in ASP.NET Core MVC Application?
    //In Attribute-Based Routing, the route is determined based on the attributes which are configured either at the controller level or at the action method level.We can use both Conventional Based Routing and Attribute-Based Routing in a single application.

    //In this article, we are going to discuss the Conventional Based Routing and in our upcoming article, we will discuss the Attribute-Based Routing.

    //    Attribute Routing in ASP.NET Core MVC:
    //With the help of ASP.NET Core Attribute Routing, you can use the Route attribute to define routes for your application.You can use the Route attribute either at the Controller level or at the Controller Action Methods level.When you apply the Route attribute at the Controller level, then it is applicable for all the action methods of that controller.

    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }
        //http://localhost:52190
        //http://localhost:52190/home
        //http://localhost:52190/home/index 
        //Now run the application and navigate to the above three URLs and you will see the output as expected

        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
