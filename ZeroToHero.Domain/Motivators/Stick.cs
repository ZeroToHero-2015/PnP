using System;
using ZeroToHero.Domain.Entities;

namespace ZeroToHero.Domain.Motivators
{
    public class Stick : IMotivator
    {
        public void Motivate(IMotivable target)
        {
            Console.Write("This stick doesn't work as advertised... ");

            target.Motivate();
        }
    }
}
