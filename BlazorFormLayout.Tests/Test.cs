using Microsoft.AspNetCore.Components.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFormLayout.Tests
{
    [TestClass]
    public class Test
    {

        private readonly TestHost host = new TestHost();

        [TestMethod]
        public void TestHost_Test()
        {

            Assert.IsNotNull(host);
        }
    }
}
