using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspNetMvcSimpleInjector;
using AspNetMvcSimpleInjector.Controllers;
using Moq;
using Services;
using System.Dynamic;

namespace AspNetMvcSimpleInjector.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var userRepositoryMock = new Mock<IUserRepository>();
            HomeController controller = new HomeController(userRepositoryMock.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void Index_Set_Usernames_in_ViewBag()
        {
            // Arrange
            var userNames = new List<string> {"a","b" };
            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(m => m.GetAllUsernames()).Returns(userNames);
            HomeController controller = new HomeController(userRepositoryMock.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;


            // Assert
            Assert.AreEqual(userNames,result.ViewBag.Usernames);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            var userRepositoryMock = new Mock<IUserRepository>();
            HomeController controller = new HomeController(userRepositoryMock.Object);

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            var userRepositoryMock = new Mock<IUserRepository>();
            HomeController controller = new HomeController(userRepositoryMock.Object);

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
