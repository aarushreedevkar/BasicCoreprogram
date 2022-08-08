using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
   public static  class SwapTwoNumbers
    {
        public static void NumberSwaping()
        {
            int a = 10;
            int b = 20;
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After swap the value is" +a +b);

        }
    }
}
