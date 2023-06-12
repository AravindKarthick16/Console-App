using System;
/*
 Bellow class develop library feature
 */

namespace prja
{
    public class UDCLMath
    {
        public int udmSum(int x, int y)
        {
            return x + y;
        }
        public static int udmMinus(int x, int y)
        {
            return x - y;
        }
        public void udmMultiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public static void udmDivide(int x, int y)
        {
            Console.WriteLine(x / y);
        }

    }
}

/*
 compiler can't run library (class)file
 */