using GleemSessions.DesignPatternsDemo.CreationalPatterns.FactoryMethod;
using GleemSessions.DesignPatternsDemo.CreationalPatterns.Singletons;
using System.Collections.Concurrent;

namespace GleemSessions.DesignPatternsDemo
{
    internal class Program
    {
        static void Main()
        {
            IShirtFactory shirtFactory = new ArabianThobeFactory();
            IShirt shirt = shirtFactory.CreateShirt();
            shirt.Describe();

            shirtFactory = new AbujaShirtFactory();
            shirt = shirtFactory.CreateShirt();
            shirt.Describe();
        }
    }
}