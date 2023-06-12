using System;
/*
 Example for TypeCasting
 */
namespace prja
{
    class TCaa
    {
        public static void Main()
        {
            string s = "fox";
            int i = 0;

            i = int.Parse(s);
            Console.WriteLine(i);
            Console.WriteLine(s);
        }
    }
}
/*
 Unhandled Exception: System.FormatException: Input string was not in a correct format.
   at System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer& number, NumberFormatInfo info, Boolean parseDecimal)
   at System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
   at System.Int32.Parse(String s)
   at prja.TCaa.Main() in C:\.net programs\visual studio\slna\prja\TCaa.cs:line 14
Press any key to continue . . .
 */
