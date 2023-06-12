using System;
/*
 Exercise: Finding big number using if conditional statement 
 */

namespace prja
{
    class IFaa
    {
        public static void Main()
        {
            int i = 5, j = 9, k = 2;
            if(i > j && i > k)
            {
                Console.WriteLine("bignumber:" + i);
            }else if (j > k)
            {
                Console.WriteLine("bignumber:" + j);
            }
            else
            {
                Console.WriteLine("bignumber:" + k);
            }

        }
    }
}
/*
bignumber:9
Press any key to continue . . .
*/


