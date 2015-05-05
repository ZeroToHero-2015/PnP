using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ZeroToHero.Domain.Entities;
using ZeroToHero.Domain.Entities.UserModels;
using ZeroToHero.Domain.Printers;
using ZeroToHero.Library.Serializers;
using ZeroToHero.Tests.Helpers;

namespace ZeroToHero.Tests
{
    [TestClass]
    public class InterfaceSegregationPrincipleTests
    {
        [TestMethod]
        public void UserGraphicModelOutputsCorrectText()
        {
            var userSerializerMock = new Mock<ISerializer<IUserGraphicModel>>();
            userSerializerMock
                .Setup(usm => usm.Serialize(It.IsAny<IUserGraphicModel>()))
                .Returns(
                    (IUserGraphicModel user) =>
                    {
                        // My very own serialization format!
                        return string.Format("-user --name:{0} --avatar:{1}", user.Name, user.Avatar);
                    });

            var userCustomFormatConsolePrinter = new ConsolePrinter<IUserGraphicModel>(userSerializerMock.Object);

            ConsoleOutputAssert.AreEqual(
                "-user --name:Dev Eloper --avatar::)",
                () =>
                {
                    userCustomFormatConsolePrinter.PrintObject(new Developer("Dev Eloper", ":)", "dev.eloper@teamnet.com"));
                });
        }

        [TestMethod]
        public void UserTextModelOutputsCorrectText()
        {
            var userSerializerMock = new Mock<ISerializer<IUserTextModel>>();
            userSerializerMock
                .Setup(usm => usm.Serialize(It.IsAny<IUserTextModel>()))
                .Returns(
                    (IUserTextModel user) =>
                    {
                        // My very own serialization format!
                        return string.Format("-user --name:{0} --email:{1}", user.Name, user.Email);
                    });

            var userCustomFormatConsolePrinter = new ConsolePrinter<IUserTextModel>(userSerializerMock.Object);

            ConsoleOutputAssert.AreEqual(
                "-user --name:Dev Eloper --email:dev.eloper@teamnet.com",
                () =>
                {
                    userCustomFormatConsolePrinter.PrintObject(new Developer("Dev Eloper", ":)", "dev.eloper@teamnet.com"));
                });
        }
    }
}
