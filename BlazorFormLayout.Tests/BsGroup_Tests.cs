using Bunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Bunit.ComponentParameterFactory;
using TestContext = Bunit.TestContext;

namespace BlazorFormLayout.Tests
{
    [TestClass]
    public class BsGroup_Tests
    {

        [TestMethod]
        public void EmptyGroupWithLabel()
        {
            using var ctx = new TestContext();

            var cut = ctx.RenderComponent<BsGroup>(
                Parameter(nameof(BsGroup.Label), "a"));

            cut.MarkupMatches(
                @"<div class=""form-group"">
                     <label class>a</label>
                  </div>");
        }

        [TestMethod]
        public void EmptyGroupWithLabel_Horizontal()
        {
            using var ctx = new TestContext();

            var cut = ctx.RenderComponent<BsGroup>(
                Parameter(nameof(BsGroup.Label), "a"),
                CascadingValue(Orientation.Horizontal));

            cut.MarkupMatches(
@" <div class=""form-group row"">
      <label class=""col-sm-4 col-md-3 col-form-label"">a</label>
      <div class=""col-sm-8 col-md-9"">
      </div>
    </div>");
        }

    }
}
