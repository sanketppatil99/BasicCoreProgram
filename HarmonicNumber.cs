using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class HarmonicNumber
    {
        public static void harmonicNumber()
        {
            Console.WriteLine("Enter the harmonic Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            double nth = 0.0;

            if (number != 0)
            {
                for (double i = 1; i <= number; i++)
                {
                    nth = nth + 1.0 / i;

                    Console.Write("1 / {0} + ",i);
                }
            }
            else
            {
                Console.WriteLine("Enter the number greater than zero");
            }
        }
    }

}
