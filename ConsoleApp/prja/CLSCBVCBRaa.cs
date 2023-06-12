using System;

namespace prja
{
    class CLSCBVCBRaa
    {
      
            public static void uSwap(int i, int j)
            {
                i = i + j;
                j = i - j;
                i = i - j;
                Console.WriteLine("swap[i]:" + i);
                Console.WriteLine("swap[j]:" + j);
            }
            public static void uExchange(ref int i, ref int j)
            {
                i = i + j;
                j = i - j;
                i = i - j;
                Console.WriteLine("uExchange[i]:" + i);
                Console.WriteLine("uExchange[j]:" + j);
            }
            public static void Main()
            {
                int a = 5, b = 2;
                int x = 4, y = 9;
                Console.WriteLine("before swap[i]:" + a);
                Console.WriteLine("before swap[j]:" + b);
                uSwap(a, b);
                Console.WriteLine("after swap[i]:" + a);
                Console.WriteLine("after swap[j]:" + b);
                Console.WriteLine("before Exchange[x]:" + x);
                Console.WriteLine("before Exchange[y]:" + y);
                uExchange(ref x, ref y);
                Console.WriteLine("after Exchange[y]:" + x);
                Console.WriteLine("after Exchange[y]:" + y);
            }

    }
}
