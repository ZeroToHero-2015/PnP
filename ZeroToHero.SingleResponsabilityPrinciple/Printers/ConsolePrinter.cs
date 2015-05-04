using System;
using ZeroToHero.Library.Serializers;

namespace ZeroToHero.Domain.Printers
{
    public class ConsolePrinter<T> : IPrinter<T>
    {
        private readonly ISerializer<T> serializer;

        public ConsolePrinter(ISerializer<T> serializer)
        {
            this.serializer = serializer;
        }

        public void PrintObject(T Object)
        {
            var serializedObject = serializer.Serialize(Object);

            Console.Write(serializedObject);
        }
    }
}
