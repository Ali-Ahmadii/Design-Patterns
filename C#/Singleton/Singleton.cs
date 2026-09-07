using System;
namespace Singleton
{
    public class Singleton
    {
        private static Singleton singleton;
        private Singleton()
        {
        }
        public static Singleton GetSingleton()
        {
            if(singleton == null)
            {
                singleton = new Singleton();
            }
            return singleton;
        }
    }
}