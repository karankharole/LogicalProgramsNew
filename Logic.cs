﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsNew
{
    internal class Logic
    {
        public void Fibonacci_Series()
        {
            int num;
            int num1 = 0;
            int num2 = 1;
            int num3;
            Console.Write("Enter the number : ");
            num = int.Parse(Console.ReadLine());
            Console.Write(" " + num1 + " " + num2 + " ");

            for (int i = 2; i <= num; i++)
            {
                num3 = num1 + num2;
                Console.Write(" " + num3 + " ");
                num1 = num2;
                num2 = num3;
            }

        }
    }
}
