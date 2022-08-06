using Microsoft.AspNetCore.Mvc;
using Pro690P2.Controllers;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            HomeController obj = new HomeController(null);
            var result = obj.About() as ViewResult;
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Test2()
        {
            HomeController obj = new HomeController(null);
            var result = obj.Index();
            result.Wait();
            var viewResult = result.Result as ViewResult;
            Assert.NotNull(viewResult);
        }


    }
}
