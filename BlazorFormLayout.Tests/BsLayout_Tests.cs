using Bunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestContext = Bunit.TestContext;
using static Bunit.ComponentParameterFactory;

namespace BlazorFormLayout.Tests
{
    [TestClass]
    public class BsLayout_Tests
    {

        [TestMethod]
        public void Defaults_Test()
        {
            using var ctx = new TestContext();

            var cut = ctx.RenderComponent<BsLayout>();

            // should be no HTML emitted from layout cascading params
            cut.MarkupMatches("");
        }
    }
}
