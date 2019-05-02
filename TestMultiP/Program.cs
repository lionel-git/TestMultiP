using LibStd;
using System;

namespace TestCore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World from Core");
                var w = new WorkerStd();
                string path = args.Length >= 1 ? args[0] : @"c:\tmp\test.log";
                Console.WriteLine(w.CheckFile(path));
                string test = "Abcd";
                Console.WriteLine($"{test} => {w.CheckStartWithA(test)}");
                Console.WriteLine("Waiting for key");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
