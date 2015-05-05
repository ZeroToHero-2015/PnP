using System;
using ZeroToHero.Domain.Motivators;

namespace ZeroToHero.Domain.Entities
{
    public class TaskMaster : User
    {
        private readonly IMotivator motivator;

        public TaskMaster(string name, string avatar, string email, IMotivator motivator) : base(name, avatar, email)
        {
            this.motivator = motivator;
        }

        public override void Work()
        {
            Console.Write("{0} is not really in the mood for working... ");
        }

        public void Motivate(IMotivable target)
        {
            Console.Write("{0} is getting ready to for some motivational speaking... or not, depending on what's injected.");

            motivator.Motivate(target);
        }
    }
}
