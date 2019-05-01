using LibStd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFW
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World from FW");
                var w = new WorkerStd();
                Console.WriteLine(w.CheckFile(@"c:\tmp\test.log"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
