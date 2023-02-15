using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientAndRemainder
    {
        public static void FindTheQuotientAndRemainder()
        {
            int divident = 20, divisor = 10;

            int quotient = divident / divisor;
            int remainder = divident % divisor;

            Console.WriteLine("Divident : {0} Divisor : {1}",divident,divisor);
            Console.WriteLine("Quotient: " +quotient);
            Console.WriteLine("Remainder : "+remainder);
        }
    }
}
