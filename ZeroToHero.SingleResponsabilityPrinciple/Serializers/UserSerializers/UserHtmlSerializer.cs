using ZeroToHero.Domain.Entities;
using ZeroToHero.Library.Serializers;

namespace ZeroToHero.Domain.Serializers.UserSerializers
{
    public class UserHtmlSerializer : ISerializer<User>
    {
        public string Serialize(User user)
        {
            return string.Format("<h2>{0} {1}</h2><p>{2}</p>", user.Name, user.Avatar, user.Email);
        }
    }
}
