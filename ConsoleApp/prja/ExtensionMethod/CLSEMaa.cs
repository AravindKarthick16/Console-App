using System;

namespace prja.Extension_method
{
    static class CLSEMaa
    {
        public static int uMath(this string aop, int x, int y)
        {
            switch (aop)
            {
                case "+":
                    return x + y;

                case "-":
                    return x - y;

                case "x":
                    return x * y;

                case "/":
                    return x / y;

                case "%":
                    return x % y;

                default:
                    return -1;
            }
        }        
        public static void Main()
        {
            Console.WriteLine("+".uMath(9, 5));
            Console.WriteLine("-".uMath(8, 4));
            Console.WriteLine("x".uMath(7, 3));
            Console.WriteLine("/".uMath(6, 2));
            Console.WriteLine("%".uMath(5, 3));
            Console.WriteLine(">".uMath(9, 5));

            int i = 16, j = 9, a, b, c, d, e, f;

            a = "+".uMath(i, j);
            b = "-".uMath(i, j);
            c = "x".uMath(i, j);
            d = "/".uMath(i, j);
            e = "%".uMath(i, j);
            f = ">".uMath(i, j);

            Console.WriteLine(a + "\n" + b + "\n" + c + "\n" + d + "\n" + e + "\n" + f);




        }



        
        

          

    }
}
