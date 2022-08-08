using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class QuotientRemaindercs
    {
        public static void CalculateQuotientRemainder()
        {
            int dividend = 50;
            int divisor = 8;
            int remainder = dividend / divisor;
            int quotient = dividend * divisor;
            Console.WriteLine("Dividend:" +dividend+ "Divisor:" +divisor);
            Console.WriteLine("Quotient:" +quotient);
            Console.WriteLine("Remainder:" +remainder);
        } 
    }
}
