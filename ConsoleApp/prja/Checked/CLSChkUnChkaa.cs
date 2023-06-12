using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.Var
{
    class CLSChkUnChkaa
    {
        public static void Main()
        {
            int x = int.MinValue;
            int y = int.MaxValue;

            Console.WriteLine(x);
            Console.WriteLine(--x);

            Console.WriteLine(y);
            Console.WriteLine(++y);



        }
    }
}
/*
 Output

-2147483648
2147483647
2147483647
-2147483648
    */
