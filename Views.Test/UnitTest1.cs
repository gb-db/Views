using System;
using Xunit;
using Views.Controllers;
using Moq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Views.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange - create the mock repository
            product pr = new product();
            pr.list = new List<string> { "P1", "P2" };
            Mock<product> mock = new Mock<product>();
            //System.Diagnostics.Debugger.Launch();
            mock.Setup(m => m.list).Returns(new List<string> { "P1", "P2" });
            // Arrange - create a controller
            HomeController target = new HomeController(mock.Object.list);
            // Action
            List<string> result  = GetViewModel<List<string>>(target.Index());
            // Assert
            Assert.Equal(2, result.Count);
            //Assert.Equal("P1", result[0].Name);
            //Assert.Equal("P2", result[1].Name);
            //Assert.Equal("P3", result[2].Name);
        }

        private T GetViewModel<T>(IActionResult result) where T : class
        {
            return (result as ViewResult)?.ViewData.Model as T;
        }
    }

    public class product
    {
        public virtual List<string> list { get; set; }
    }

}
