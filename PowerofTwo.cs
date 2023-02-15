﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerofTwo
    {
        public static void powerofTwo()
        {

            Console.WriteLine("Enter the value of 'N' below to find table of power 2 ..");
            Console.WriteLine("Enter the value N between 0 and 31 =  ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0 && n < 31)
            {
                for (int i = 0; i <= n; i++)
                {
                    double pow = Math.Pow(2, i);
                    Console.WriteLine("2 ^ {0} is = {1}", i, pow);
                }
            }
            else
            {
                Console.WriteLine("Entered number not valid");
            }
        }
    }
}
