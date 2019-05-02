using System;
using System.Diagnostics;
using System.IO;
using PCRE;

namespace LibStd
{
    public class WorkerStd
    {
        public int CheckFile(string path)
        {
            int pid = Process.GetCurrentProcess().Id;
            Console.WriteLine($"pid={pid}");
            var buffer = File.ReadAllBytes(path);
            return buffer.Length;
        }

        public bool CheckStartWithA(string name)
        {
            var pcre = new PcreRegex("^A.*");
            return pcre.IsMatch(name);
        }
    }
}
