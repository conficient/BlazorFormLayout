using Microsoft.AspNetCore.Components.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFormLayout.Tests
{
    [TestClass]
    public class BsCard_Tests
    {
        private readonly TestHost host = new TestHost();

        [TestMethod]
        public void EmptyCard_Test()
        {
            var parameters = new ParameterBuilder()
                .Add("HeaderCss", "a")
                .ToParameterView();
                
            var layout = host.AddComponent<BsCard>(parameters);

            // header includes specified css

            // content is empty
            Assert.IsTrue(string.IsNullOrWhiteSpace(layout.Find("div.card-body").InnerText));
        }
    }

}
