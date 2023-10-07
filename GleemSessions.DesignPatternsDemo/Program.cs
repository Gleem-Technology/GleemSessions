using GleemSessions.DesignPatternsDemo.CreationalPatterns;
using System.Collections.Concurrent;

namespace GleemSessions.DesignPatternsDemo
{
    internal class Program
    {
        static ConcurrentBag<BasicSingleton> basicSingletons = new();
        static ConcurrentBag<ThreadSafeSingleton> threadSafeSingleton = new();

        static void Main()
        {
            Parallel.For(0, 2, i =>
            {
                basicSingletons.Add(BasicSingleton.GetInstance());
                threadSafeSingleton.Add(ThreadSafeSingleton.GetInstance());
            });

            for (int i = 0; i < 2; i++)
            {
                basicSingletons.Add(BasicSingleton.GetInstance());
                threadSafeSingleton.Add(ThreadSafeSingleton.GetInstance());
            }

            var arr = basicSingletons.ToArray();
            var arr = threadSafeSingleton.ToArray();

            Console.WriteLine(arr[0].GetHashCode());
            Console.WriteLine(arr[1].GetHashCode());

            Console.WriteLine(ReferenceEquals(arr[0], arr[1]));
        }
    }
}