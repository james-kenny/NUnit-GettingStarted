using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Demo.Data
{
    public class Provider
    {
        public int Id { get; set; }
        
        public string Provider_Code_CH { get; set; }
        
        public string Provider_Name_VC { get; set; }
        
        public string Current_Title_VC { get; set; }

        public string Current_Status_VC { get; set; }

        public DateTime Updated_DT { get; set; }

        public string Display_Date { get; set; }

        public Boolean Preview_BT { get; set; }
    }
}
