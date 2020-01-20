using Microsoft.AspNetCore.Components;
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
    public class BsGroup_Tests
    {
        private readonly TestHost host = new TestHost();

        [TestMethod]
        public void EmptyGroupTest()
        {
            var parameters = new ParameterBuilder()
                .Add("Label", "a")
                .ToParameterView();

            var component = host.AddComponent<BsGroup<string>>(parameters);

            // check form group
            var html = component.Find("div").OuterHtml;
            StringAssert.StartsWith(html, "<div class=\"form-group\">");
        }
    }
}
