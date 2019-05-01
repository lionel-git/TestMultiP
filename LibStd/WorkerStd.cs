using System;
using System.IO;

namespace LibStd
{
    public class WorkerStd
    {
        public int CheckFile(string path)
        {
            var buffer = File.ReadAllBytes(path);
            return buffer.Length;
        }
    }
}
