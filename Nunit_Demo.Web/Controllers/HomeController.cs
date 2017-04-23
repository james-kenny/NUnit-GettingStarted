using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nunit_Demo.Data;
using Nunit_Demo.Web.Models;

namespace Nunit_Demo.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AppViewModel _wrapper = new AppViewModel();

            ProviderQueries PQ = new ProviderQueries();

            _wrapper.providers = PQ.GetProviders();

            return View(_wrapper);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}