using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Demo.Data
{
    public class ProviderQueries
    {
        private string DateFormat = "dd MMM yyyy";

        public List<Provider> GetProviders()
        {
            List<Provider> _records = new List<Provider>();

            _records.Add(AddProvider(1, "Azure", "Windows Azure", "All Ok", "Running Fine"));
            _records.Add(AddProvider(2, "AWS", "Amazon Web Services", "All Ok", "Running Fine"));


            return _records;
        }


        // This method will throw an expection to see the test failing.
        public List<Provider> GetProvidersNoDatabase()
        {
            List<Provider> _records = new List<Provider>();
            

            throw  new Exception("database missing");
        }

        public Provider AddProvider(int Id, string ProviderCode, string ProviderName, string Title, string Status)
        {
            Provider _record = new Provider
            {
                Id = Id,
                Provider_Code_CH = ProviderCode,
                Provider_Name_VC = ProviderName,
                Current_Title_VC = Title,
                Current_Status_VC = Status,
                Updated_DT = DateTime.Now,
                Display_Date = DateTime.Now.ToString(DateFormat),
                Preview_BT = false
            };

            return _record;
        }
    }
}
