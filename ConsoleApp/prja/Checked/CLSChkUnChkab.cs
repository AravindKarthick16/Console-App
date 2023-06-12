using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.Checked
{
    class CLSChkUnChkab
    {
        public static void Main()
        {
            int x = int.MinValue;
            int y = int.MaxValue;

            Console.WriteLine(x);
            Console.WriteLine(y);

            checked
            {
                //Console.WriteLine(--x); //OverflowExeception
            }
            checked
            {
                //Console.WriteLine(++y);  //OverflowException
            }
        }
    }
}
