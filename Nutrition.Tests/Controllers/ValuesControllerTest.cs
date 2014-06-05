using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Nutrition.Common.Testing;
using Nutrition.Controllers;
using Nutrition.UI.Services;
using Ploeh.AutoFixture;

namespace Nutrition.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            var fixture = new Fixture().Customize(new ApiControllerConventions());
            var simplecomponent = fixture.Freeze<ISimpleComponent>();

            simplecomponent.Greeting().Returns("plop");

            var controller = fixture.Create<ValuesController>();

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
            result.ElementAt(2).Should().Be("plop");
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            var controller =
                new Fixture().Customize(new ApiControllerConventions()).Create<ValuesController>();

            // Act
            var result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            var controller =
                new Fixture().Customize(new ApiControllerConventions()).Create<ValuesController>();


            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            var controller =
                new Fixture().Customize(new ApiControllerConventions()).Create<ValuesController>();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            var controller =
                new Fixture().Customize(new ApiControllerConventions()).Create<ValuesController>();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
