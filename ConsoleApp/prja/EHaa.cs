using System;
/*
 Example for exception handling
 */

namespace prja
{
    class EHaa
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Welcome");

                    int i = 10, j = 0;

                Console.WriteLine(i / j);

                Console.WriteLine("Thanks");
            }catch(Exception e)
            {
                Console.WriteLine("err.:" + e.Message);
               
            }
            Console.WriteLine("Visit again");
        }
    }
}
/*
Welcome
err.:Attempted to divide by zero.
Visit again
Press any key to continue . . .
*/
