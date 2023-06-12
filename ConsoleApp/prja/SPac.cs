using System;
/*
 Below class (SPac) call user defined class library(UDCLMath)
 file (UDCLMath.cs)
 */
namespace prja
{
    class SPac
    {
        public static void Main()
        {
            UDCLMath umath = new UDCLMath();

            Console.WriteLine(umath.udmSum(1, 9));

            umath.udmMultiply(2, 8);

            Console.WriteLine(UDCLMath.udmMinus(6, 2));

            UDCLMath.udmDivide(20, 3);

        }
    }
}
/*
 10
16
4
6
Press any key to continue . . .
*/