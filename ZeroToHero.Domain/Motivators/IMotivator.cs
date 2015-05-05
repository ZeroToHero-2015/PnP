using ZeroToHero.Domain.Entities;

namespace ZeroToHero.Domain.Motivators
{
    public interface IMotivator
    {
        void Motivate(IMotivable target);
    }
}
