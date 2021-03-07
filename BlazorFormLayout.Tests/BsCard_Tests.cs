using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestContext = Bunit.TestContext;
using static Bunit.ComponentParameterFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bunit;

namespace BlazorFormLayout.Tests
{
    [TestClass]
    public class BsCard_Tests
    {

        [TestMethod]
        public void EmptyCard_Test()
        {
            var ctx = new TestContext();

            var cut = ctx.RenderComponent<BsCard>(
                Parameter("HeaderCss", "a"));

            cut.MarkupMatches(
@"<div class=""card "">
     <div class=""card-body"">
     </div>
  </div>");
        }
    }

}
