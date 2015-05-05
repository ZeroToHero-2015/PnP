using System;
using ZeroToHero.Domain.Entities;

namespace ZeroToHero.Domain.Motivators
{
    public class Carrot : IMotivator
    {
        public void Motivate(IMotivable target)
        {
            Console.Write("This carrot seems to be very good at motivating people... ");

            target.Motivate();
        }
    }
}
