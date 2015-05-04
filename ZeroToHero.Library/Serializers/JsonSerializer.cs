using Newtonsoft.Json;

namespace ZeroToHero.Library.Serializers
{
    public class JsonSerializer<T> : ISerializer<T>
    {
        public string Serialize(T Object)
        {
            return JsonConvert.SerializeObject(Object);
        }
    }
}
