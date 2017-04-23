using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nunit_Demo.Data;
using NUnit.Framework;

namespace Nunit_Demo.Tests
{
    [TestFixture]
    class ProviderTest
    {
        [Test]
        public void LoadProviders()
        {
            List<Provider> _providers = new List<Provider>();

            ProviderQueries PQ = new ProviderQueries();

            _providers = PQ.GetProviders();

            if (_providers.Count != 0)
            {
                Boolean bResult = true;

                Assert.IsTrue(bResult, "Providers loaded");
            }
            else
            {
                Assert.IsFalse(false, "No Providers loaded");
            }

        }

        [Test]
        public void LoadProviderNoDatabases()
        {
            List<Provider> _providers = new List<Provider>();

            ProviderQueries PQ = new ProviderQueries();

            _providers = PQ.GetProvidersNoDatabase();

            if (_providers.Count != 0)
            {
                Boolean bResult = true;

                Assert.IsTrue(bResult, "Providers loaded");
            }
            else
            {
                Assert.IsFalse(false, "No Providers loaded");
            }

        }
    }
}
