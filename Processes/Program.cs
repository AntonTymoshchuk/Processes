using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Processes
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] CurrentProcesses = Process.GetProcesses();
            for (int i=0;i<CurrentProcesses.Length;i++)
            {
                Console.WriteLine(CurrentProcesses[i].ProcessName);
            }
        }
    }
}
