using System;
using ZeroToHero.Domain.Entities.UserModels;

namespace ZeroToHero.Domain.Entities
{
    public abstract class User : IUserGraphicModel, IUserTextModel, IMotivable
    {
        private readonly string name;
        private readonly string avatar;
        private readonly string email;

        protected User(string name, string avatar, string email)
        {
            this.name = name;
            this.avatar = avatar;
            this.email = email;
        }

        public string Name
        {
            get { return name; }
        }

        public string Avatar
        {
            get { return avatar; }
        }

        public string Email
        {
            get { return email; }
        }

        public virtual void Greet()
        {
            Console.Write("{0} waves at you!", name);
        }

        public abstract void Work();

        public void Motivate()
        {
            Console.Write("{0} feels somewhat more motivated.", name);
        }
    }
}
