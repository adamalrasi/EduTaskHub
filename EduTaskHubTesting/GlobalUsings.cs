
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

using Xunit;
using YourWebAppProject.Controllers; // Assuming your controller is in this namespace

namespace YourWebAppTestProject.Tests
{
    public class HelloWorldControllerTests
    {
        [Fact]
        public async void Get_Index_ReturnsHelloWorld()
        {
            // Arrange
            var controller = new HomeController(); // Instantiate the controller directly

            // Act
            var result = await controller.Index(); // Call the Index action
            var responseString = await result.Content.ReadAsStringAsync();

            // Assert
            Assert.Equal("Hello World!", responseString); // Verify the expected output
        }
    }
}