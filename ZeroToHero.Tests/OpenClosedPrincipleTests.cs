using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZeroToHero.Domain.Entities;

namespace ZeroToHero.Tests
{
    [TestClass]
    public class OpenClosedPrincipleTests
    {
        [TestMethod]
        public void DeveloperLosesStaminaWhenGreeting()
        {
            var developer = new Developer("Dev Eloper", ":)", "dev.eloper@teamnet.ro");

            var initialStamina = developer.Stamina;

            developer.Greet();

            var staminaAfterGreeting = developer.Stamina;

            Assert.IsTrue(initialStamina > staminaAfterGreeting);
        }
    }
}
