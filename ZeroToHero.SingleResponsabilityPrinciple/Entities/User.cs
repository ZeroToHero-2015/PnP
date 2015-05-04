using System;

namespace ZeroToHero.Domain.Entities
{
    public class User
    {
        private readonly string name;
        private readonly string avatar;
        private readonly string email;

        public User(string name, string avatar, string email)
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
    }
}
