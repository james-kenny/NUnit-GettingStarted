using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nunit_Demo.Data;

namespace Nunit_Demo.Web.Models
{
    public class AppViewModel
    {
        public List<Provider> providers { get; set; }
        public Provider providerDetail { get; set; }
    }
}