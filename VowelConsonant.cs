using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class VowelConsonant
    {
        public static void VowelOrConsonant()
        {
            char c = Convert.ToChar(Console.ReadLine());
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' )
            {
                Console.WriteLine("vowel");

            }
            else
            {
                Console.WriteLine("consonant");


        }
       
        }

    }
}


