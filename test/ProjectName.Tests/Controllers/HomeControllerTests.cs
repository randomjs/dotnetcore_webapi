using System;
using Xunit;
using ProjectName.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
namespace ProjectName.Tests.Controllers 
{
    public class HomeControllerTests
    {
        public void SetUp()
        {
        }

        [Fact]
        public void When_Call_List_Action_Should_Return_Array_Containing_Three_Elements()
        {
            var homeController = new HomeController();
            var actionResult =  homeController.List();
            Assert.IsType<OkObjectResult>(actionResult);

        }


    }


}
