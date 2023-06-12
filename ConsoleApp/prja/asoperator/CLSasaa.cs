using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prja.asoperator
{
    class CLSasaa
    {
        public void udshow(int? i)
        {
            if(i == null)
            {
                return;
            }

            Console.WriteLine(i);
        }

        public static void Main()
        {
            ArrayList aL = new ArrayList();
            aL.Add("56.5");

            Console.WriteLine("{0} : {1}", aL[0], aL.GetType());

            string s = aL[0] as string;

            Console.WriteLine("{0} : {1}", s, s.GetType());

            CLSasaa aa = new CLSasaa();
            aa.udshow(null);
            aa.udshow(9);

        }
    }
}

/*
 *56.5 : System.Collections.ArrayList
56.5 : System.String
9
*/
