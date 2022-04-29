using ReportPortal.Shared;
using System;
using System.Collections;
using Xunit;

namespace ExampleUnitTests.XUnitTests
{
    public class UnitTest3
    {
        [Fact, Trait("Category", "Category1"), Trait("Category", "Category2")]
        public void Test1()
        {

        }

        [Fact(DisplayName = "OverriddenTest2")]
        public void Test2()
        {

        }

        [Theory]
        [InlineData("a")]
        [InlineData(".withdot")]
        [InlineData("with.dot")]
        public void Test3(string a)
        {

        }
    }
}
