using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZeroToHero.Domain.Entities;
using ZeroToHero.Tests.Helpers;

namespace ZeroToHero.Tests
{
    [TestClass]
    public class LiskovSubstitutionPrincipleTests
    {
        [TestMethod]
        public void DeveloperHoldsLinksovSubstitutionPrinciple()
        {
            User userDeveloper = new Developer("Dev Eloper", ":)", "dev.eloper@teamnet.ro");
            Developer developer = new Developer("Dev Eloper", ":)", "dev.eloper@teamnet.ro");

            ConsoleOutputAssert.AreEqual(userDeveloper.Greet, developer.Greet);
        }

        [TestMethod]
        public void DevsAndManagersWorkDifferently()
        {
            User developer = new Developer("Dev Eloper", ":)", "dev.eloper@teamnet.ro");
            Manager manager = new Manager("Man Ager", ":)", "man.ager@teamnet.ro");

            ConsoleOutputAssert.AreNotEqual(developer.Work, manager.Work);
        }
    }
}
