using System;
/*
 Example for TypeCasting
 */

namespace prja
{
    class TCab
    {
        public static void Main()
        {
            string s = "fox";
            int i = 0;

            int.TryParse(s, out i);

            Console.WriteLine(i + "-" + i.GetType());
            Console.WriteLine(s + "-" + s.GetType());

        }
    }
}
/*
 0-System.Int32
 fox-System.String
 Press any key to continue . . .
*/