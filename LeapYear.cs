using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class LeapYear
    {
        public static void FindLeapYear()
        {
            int year;
           
            Console.Write("Check whether a given year is leap year or not:");
          
           
            Console.Write("Input an Year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400) == 0)
                Console.WriteLine("Year is leap Year",year);
            else if ((year % 100) == 0)
                Console.WriteLine("Year is not a leap Year",year );
            else if ((year % 4) == 0)
                Console.WriteLine("Year is a leap Year" ,year);
            else
                Console.WriteLine("Year is not a leap Year",year);
        }
    }
}
    

