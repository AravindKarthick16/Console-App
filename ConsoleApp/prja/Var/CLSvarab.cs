using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.Var
{
    class CLSvarab
    {
        public static void Main()
        {
            var er = new { Rno = 1001, Sname = "x5", M1 = 56.5, M2 = 72 };

            Console.WriteLine("Roll no.: {0}", er.Rno);
            Console.WriteLine("Name: {0}", er.Sname);
            Console.WriteLine("Mark-1: {0}", er.M1);
            Console.WriteLine("Mark-2: {0}", er.M2);

            Console.WriteLine("Total: {0}", er.M1 + er.M2);
            Console.WriteLine("Average: {0}", (er.M1 + er.M2)/ 2);
            Console.WriteLine("Result: {0}", (er.M1 > 34.4 && er.M2 > 34.4 ? "Pass" : "Fail" ));

        }
    }
}

/*
 Output

Roll no.: 1001
Name: x5
Mark-1: 56.5
Mark-2: 72
Total: 128.5
Average: 64.25
Result: Pass

    */
