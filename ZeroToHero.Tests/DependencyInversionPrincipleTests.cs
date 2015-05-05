using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ZeroToHero.Domain.Entities;
using ZeroToHero.Domain.Motivators;

namespace ZeroToHero.Tests
{
    [TestClass]
    public class DependencyInversionPrinciple
    {
        [TestMethod]
        public void TaskMastersCanUseWhateverMotivators()
        {
            var stickMotivator = new Stick();
            var carrotMotivator = new Carrot();

            var motivableMock = new Mock<IMotivable>();

            var taskMasterStick = new TaskMaster("Task 'The Stick' Master", "x(", "task.master.stick@teamnet.ro", stickMotivator);
            var taskMasterCarrot = new TaskMaster("Task 'The Carrot' Master", "x(", "task.master.carrot@teamnet.ro", carrotMotivator);

            taskMasterStick.Motivate(motivableMock.Object);
            taskMasterCarrot.Motivate(motivableMock.Object);

            motivableMock.Verify(mm => mm.Motivate(), Times.Exactly(2));
        }
    }
}
