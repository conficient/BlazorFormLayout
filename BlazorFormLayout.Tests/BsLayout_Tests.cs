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
    public class BsLayout_Tests
    {
        private readonly TestHost host = new TestHost();

        [TestMethod]
        public void Defaults_Test()
        {
            var layout = host.AddComponent<BsLayout>();

            // default orientiation
            Assert.AreEqual(Orientation.Vertical, layout.Instance.Orientation);

            // default mode
            Assert.AreEqual(EditMode.Editing, layout.Instance.EditMode);
        }
    }
}
