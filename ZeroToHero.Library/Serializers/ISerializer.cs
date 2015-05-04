namespace ZeroToHero.Library.Serializers
{
    public interface ISerializer<T>
    {
        string Serialize(T Object);
    }
}
