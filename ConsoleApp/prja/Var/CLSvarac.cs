using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.Var
{
    class CLSvarac
    {
        public static void Main()
        {
            var er = new { RNo = 1001, SName = new { FName = "Ganesh", LName = "Siva" } };

            Console.WriteLine("Roll no.: {0}", er.RNo);
            Console.WriteLine("Name: {0}", er.SName);
            Console.WriteLine("First name: {0}", er.SName.FName);
            Console.WriteLine("Last name: {0}", er.SName.LName);

        }
    }
}

/*
 Output

 Roll no.: 1001
 Name: { FName = Ganesh, LName = Siva }
 First name: Ganesh
 Last name: Siva

 */
 
