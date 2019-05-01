using System;
using System.Diagnostics;
using System.IO;

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
    }
}
