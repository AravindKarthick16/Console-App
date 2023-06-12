using System;

/*
 Example for Sub program(category: Procedure)
 */

namespace prja
{
    class SPab
    {
        public void udSum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void udMinus(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public static void Main()
        {
            SPab spb = new SPab();
            spb.udSum(1, 9);
            SPab.udMinus(6, 3);
        }
    }
}
/*
 10
 3
 Press any key to continue . . .
*/