using System;

namespace prja.MDLaa
{
    class Home
    {
        public static void Main()
        {
            Console.WriteLine("Choose execute App:\n");
            Console.WriteLine("1.Exam Result");
            Console.WriteLine("2.Employee Allowance");
            Console.WriteLine("3.Salary Tax");
            Console.WriteLine("4.Electricity Bill");

            Console.Write("Enter App no between 1 to 4:");

            int i = 0;
            int.TryParse(Console.ReadLine(), out i);

            if(!(i>=1 && i<=4))
            {
                Console.WriteLine("Invalid App no.");
                return;
            }
            if (i==1)
            {
                CLSERaa.Main();
                return;
            }
            if (i == 2)
            {
                CLSEAaa.Main();
                return;
            }
            if (i == 3)
            {
                CLSSTaa.Main();
                return;
            }
            if (i==4)
            {
                CLSEBaa.Main();
            }
        }
    }
}
