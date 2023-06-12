using System;


namespace prja.MDLaa
{
    class CLSERaa
    {
        public static void Main()
        {
            int rno = 1001;
            string sname = "x5";
            double m1 = 36.5, m2 = 52;

            double total = (m1 + m2), avg = (m1 + m2) / 2;
            bool result = (m1 > 34.4 && m2 > 34.4);

            Console.WriteLine("Exam Result Info:\n");

            Console.WriteLine("Roll no:\t" + rno);
            Console.WriteLine("Name:\t" + sname);
            Console.WriteLine("Mark-1:\t" + m1);
            Console.WriteLine("Mark-2:\t" + m2);

            Console.WriteLine("Total:\t" + total);
            Console.WriteLine("Average:\t" + avg);
            Console.WriteLine("Result:\t" + (result ? "pass" : "fail"));
        }
    }  
}
/*
Exam Result Info:

Roll no:        1001
Name:   x5
Mark-1: 36.5
Mark-2: 52
Total:  88.5
Average:        44.25
Result: pass
Press any key to continue . . .
*/
