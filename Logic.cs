using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsNew
{
    internal class Logic
    {
        public void harmonicSeries(int n)
        {
            double value = 0;
            for (int i = 1; i <= n; i++)
            {
                value += 1 / (float)i;
            }
            Console.WriteLine(value);
            Console.WriteLine("Sum of n Numbher of Hrmonic series is " + value);
        }
    }
}
