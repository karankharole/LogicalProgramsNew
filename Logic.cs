using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsNew
{
    internal class Logic
    {
        public void Reverse_Number()
        {
            Console.WriteLine("\n");
            int n, reverse = 0, rem;
            Console.Write("Enter a number : ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}
