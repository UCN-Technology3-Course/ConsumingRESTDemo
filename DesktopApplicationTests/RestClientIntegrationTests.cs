using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Tests
{
    [TestClass()]
    public class RestClientIntegrationTests
    {
        [TestMethod()]
        public void GetCityDataTest()
        {
            RestClient client = new RestClient();
            var city = client.GetCityData("9000").GetAwaiter().GetResult();

            Assert.AreEqual("Aalborg", city.Navn);
        }
    }
}