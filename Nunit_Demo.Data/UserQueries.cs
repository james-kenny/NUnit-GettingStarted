using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Demo.Data
{
    public class UserQueries
    {
        public string Message { get; set; }

        public int InsertUser(string sFirstName, string sLastName, string sEmail, int iNumber)
        {
            int iUserID = 0;



            // Create our user 
            User _user = new User
            {
                Email_VC = sEmail,
                FirstName_VC = sFirstName,
                LastName_VC = sLastName,
                Number_IN = iNumber
            };

            // Add code here to save user to the database.
            iUserID = 1;
            Message = "";

            return iUserID;
        }

        public Boolean DeleteUser(int iUserId)
        {
            Boolean bSuccess = false;

            // Here we add code to delete the user from the database.
            bSuccess = true;

            return bSuccess;
        }
    }
}
