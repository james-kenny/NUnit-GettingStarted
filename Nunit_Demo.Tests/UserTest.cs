using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Nunit_Demo.Web.Controllers;
using NUnit.Framework;

namespace Nunit_Demo.Tests
{
    [TestFixture]
    public class UserTest
    {
        [Test]
        public void CreateUserTest()
        {
            string sFirstName = "James";
            string sLastName = "Test";
            string sEmail = "test@serversncode.com";
            int iNumber = 7;
            Boolean bTestSuccess = false;
            string sMessage = "";


            HomeController _homeController = new HomeController();

            ActionResult result = _homeController.SaveUser(sFirstName, sLastName, sEmail, iNumber);

            var actResult = (RedirectResult)result;
            int iUserID = 0;

            // User Added successfully
            if (actResult.Url.StartsWith("/UserAdded?id="))
            {
                // We remove the URL and pull the ID for the new user we just created
                string sURL = actResult.Url.Replace("/UserAdded?id=", "");

                iUserID = Convert.ToInt32(sURL);

                // If the user ID not 0
                if (iUserID != 0)
                {
                    bTestSuccess = true;
                    sMessage = "User Saved ok";
                }
                else
                {
                    // If UserId is 0 something went wrong and the User didn't save ok, 
                    // So the test fails.
                    bTestSuccess = false;
                    sMessage = "User Save failed";
                }
            }
            else
            {
                // If the result URL is Save user
                string sURL = actResult.Url.Replace("/saveuser?message=", "");



                // The test has passed if this code is hit.
                bTestSuccess = true;
                sMessage = "";
            }


            // Test fails if bTestSuccess is false;
            Assert.IsTrue(bTestSuccess, sMessage);

        }

        [Test]
        public void CreateUserNoNameTest()
        {

            string sFirstName = "";
            string sLastName = "";
            string sEmail = "test@serversncode.com";
            int iNumber = 7;
            Boolean bTestSuccess = false;
            string sMessage = "";


            HomeController _homeController = new HomeController();

            ActionResult result = _homeController.SaveUser(sFirstName, sLastName, sEmail, iNumber);

            var actResult = (RedirectResult)result;
            int iUserID = 0;


            // User Added successfully
            if (actResult.Url.StartsWith("/UserAdded?id="))
            {
                // With this test we are not expecting to be here. 
                // If we are then something went wrong in our validation.
                bTestSuccess = false;
                sMessage = "User Save failed";
            }
            else
            {
                // If the result URL is Save user
                sMessage = actResult.Url.Replace("/saveuser?message=", "");

                // The test has passed if this code is hit.
                bTestSuccess = true;
            }


            // Test fails if bTestSuccess is false;
            Assert.IsTrue(bTestSuccess, sMessage);
        }
    }
}
