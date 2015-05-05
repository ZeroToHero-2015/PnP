using System;

namespace ZeroToHero.Domain.Entities
{
    public class Developer : User
    {
        private int stamina;

        public Developer(string name, string avatar, string email)
            : base(name, avatar, email)
        {
            stamina = 100;
        }

        public int Stamina
        {
            get { return stamina; }
        }

        public override void Greet()
        {
            if (stamina != 0)
            {
                base.Greet();
            }

            stamina -= 5;
        }

        public override void Work()
        {
            Develop();
        }

        protected void Develop()
        {
            Console.Write("{0} is developing something... ", Name);
        }
    }
}
