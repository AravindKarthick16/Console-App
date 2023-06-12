using System;

namespace prja.MDLaa
{
    class CLSEAaa
    {
        public static void Main()
        {
            Console.WriteLine("Enter Employee Info");
            string ip = null;

            Console.Write("ID:\t");
            ip = Console.ReadLine();

            int eid = 0;
            int.TryParse(ip, out eid);

            Console.Write("Name:\t");
            string ename = Console.ReadLine();

            Console.Write("Salary:\t");
            ip = Console.ReadLine();

            double esal = 0;
            double.TryParse(ip, out esal);

            double hra = 0, da = 0, pf = 0, gpay = 0, npay = 0;

            hra = esal * 20.0 / 100;
            da = esal * 15.0 / 100;
            pf = esal * 35.0 / 100;

            gpay = esal + hra + da;
            npay = gpay - pf;

            Console.WriteLine("\n Employee Info \t");
            Console.WriteLine("ID: \t" + eid);
            Console.WriteLine("Name:\t" + ename);
            Console.WriteLine("Salary:\t" + esal);
            Console.WriteLine("House Rent Allowance:\t" + hra);
            Console.WriteLine("Dearness Allowance:\t" + da);
            Console.WriteLine("Provident fund:\t" + pf);
            Console.WriteLine("Gross pay:\t" + gpay);
            Console.WriteLine("Net Pay:\t" + npay);

        }
    }
}
