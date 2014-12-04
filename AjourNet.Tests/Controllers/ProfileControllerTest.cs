using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using AjourNet.Controllers;
using System.Web.Mvc;
using AjourNet.Domain.ViewModels;
using AjourNet.Domain.Entities;

namespace AjourNet.Tests.Controllers
{
    [TestFixture]
    class ProfileControllerTest
    {
        ProfileController controller = new ProfileController();

        [Test]
        public void GetProfile_NazariiTashakDefault_View()
        {
            //Arrange
            //Act
            var result = controller.GetProfile() as PartialViewResult;
            var modelResult = result.Model as UserProfileModel;

            //Assert
            Assert.AreEqual("", result.ViewName);
            Assert.AreEqual("Nazarii", modelResult.FirstName);
            Assert.AreEqual("Tashak", modelResult.LastName);
            Assert.AreEqual("Junior Software Developer", modelResult.Occupation);
            Assert.AreEqual("LV/G", modelResult.Location);
            Assert.AreEqual(Status.Online, modelResult.Status);
            Assert.AreEqual("3346", modelResult.PhoneNumber);
            Assert.AreEqual("To be or not to be", modelResult.Motto);
        }
    }
}
