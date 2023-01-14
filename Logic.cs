using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsNew
{
    internal class Logic
    {
        public void CalculateStopWatchTime(int s)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine(".");
            }
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : " + stopwatch.Elapsed);
        }

    }
}
