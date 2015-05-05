using System;

namespace ZeroToHero.Domain.Entities
{
    public class Manager : User
    {
        public Manager(string name, string avatar, string email) : base(name, avatar, email)
        {
        }

        public override void Work()
        {
            Manage();
            MakeSomePhoneCalls();
        }

        private void MakeSomePhoneCalls()
        {
            Console.Write("{0} is making some phone calls... ", Name);
        }

        private void Manage()
        {
            Console.Write("{0} is managing something... ", Name);
        }
    }
}
