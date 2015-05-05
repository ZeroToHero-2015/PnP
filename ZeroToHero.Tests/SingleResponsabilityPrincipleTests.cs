using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ZeroToHero.Domain.Entities;
using ZeroToHero.Domain.Printers;
using ZeroToHero.Library.Serializers;
using ZeroToHero.Tests.Helpers;

namespace ZeroToHero.Tests
{
    [TestClass]
    public class SingleResponsabilityPrincipleTests
    {
        [TestMethod]
        public void UserOutputIsDecoupledFromUser()
        {
            var userSerializerMock = new Mock<ISerializer<User>>();
            userSerializerMock
                .Setup(usm => usm.Serialize(It.IsAny<User>()))
                .Returns(
                    (User user) =>
                    {
                        // My very own serialization format!
                        return string.Format("-user --name:{0} --avatar:{1} --email:{2}", user.Name, user.Avatar, user.Email);
                    });

            var userCustomFormatConsolePrinter = new ConsolePrinter<User>(userSerializerMock.Object);

            ConsoleOutputAssert.AreEqual(
                "-user --name:Foo --avatar::) --email:foo@bar.com",
                () =>
                {
                    userCustomFormatConsolePrinter.PrintObject(new Developer("Foo", ":)", "foo@bar.com"));
                });
        }
    }
}
