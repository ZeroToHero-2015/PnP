namespace ZeroToHero.Domain.Printers
{
    public interface IPrinter<T>
    {
        void PrintObject(T Object);
    }
}
