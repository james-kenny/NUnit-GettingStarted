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


        //Save User method to demonstrate Unit testing of parameters
        public ActionResult SaveUser(string firstname, string lastname, string email, int number)
        {
            UserQueries UQ = new UserQueries();

            int iUserId = 0;
            Boolean bValid = true;

            // Validate User Input
            // Do we have a first name
            bValid = (firstname == "" ? false : true);

            if (bValid)
            {
                // Do we have a last name
                bValid = (lastname == "" ? false : true);
            }

            if (bValid)
            {
                // Do we have an email
                bValid = (email == "" ? false : true);
            }

            
            // If Valid Save User
            if (bValid)
            {
                iUserId = UQ.InsertUser(firstname, lastname, email, number);
            }


            if (!bValid)
            {
                return Redirect("/saveuser?message=MissingInformation");
            }
            else
            {
                return Redirect("/UserAdded?id=" + iUserId);
            }
        }
    }
}