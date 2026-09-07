using System;
namespace Singleton
{
    class Program
    {
        static void Main()
        {
            var v1 = Singleton.GetSingleton();
            var v2 = Singleton.GetSingleton();
            Console.WriteLine(v1.GetHashCode());
            Console.WriteLine(v2.GetHashCode());
        }
    }
}