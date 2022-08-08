using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static  class FlipCoin
    {
        public static void CalculatePercentage()

        {
            int head = 0;
            int tail = 0;
            int headCount = 0;
            int tailCount = 0;
            double headPercentage = 0;
            double tailPercentage = 0;
            Console.WriteLine("plaese enter the value for number of flip");
            int flipCoin = Convert.ToInt32(Console.ReadLine());
            if(flipCoin > 0)
            {
                for (int i = 0; i < flipCoin; i++) ;
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    {
                        if(number == 0)
                        {
                            headCount++;
                        }
                        else
                        {
                            tailCount++;
                        }
                    }
                    headPercentage = headCount * 100 / flipCoin;
                    tailPercentage = tailCount * 100 / flipCoin;
                    Console.WriteLine("The Head percentage is" + headPercentage);
                    Console.WriteLine("The Head percentage is" + tailPercentage);
                }
            }



        } 
    }
    
    }

