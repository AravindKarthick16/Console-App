using System;
/*
 Exercise: Exam result develop with dynamic input or run time input
 */

namespace prja
{
    class ERab
    {
        public static void Main()
        {
            Console.WriteLine("Enter following inputs for Exam Result exercise");

            string ip = null;
            Console.Write("\nRoll number:\t");
            ip = Console.ReadLine();

            int rno = 0;

            int.TryParse(ip, out rno);

            Console.Write("\nStudent name:\t");
            string sname = Console.ReadLine();

            Console.Write("\nMark-1:\t");
            ip = Console.ReadLine();

            double m1 = 0;
            double.TryParse(ip, out m1);

            Console.Write("\nMark-2:\t");
            ip = Console.ReadLine();

            double m2 = 0;
            double.TryParse(ip, out m2);

            double total = (m1 + m2), avg = (m1 + m2) / 2;
            bool result = (m1 > 34.4 && m2 > 34.4);

            Console.WriteLine("Exam Result Info:\n");

            Console.WriteLine("Roll no:\t"+ rno);
            Console.WriteLine("Name:\t" + sname);
            Console.WriteLine("Mark-1:\t" + m1);
            Console.WriteLine("Mark-2:\t" + m2);

            Console.WriteLine("Total:\t" + total);
            Console.WriteLine("Average:\t" + avg);
            Console.WriteLine("Result:\t" + (result? "Pass":"Fail"));
        }
    }
}
/*
 Enter following inputs for Exam Result exercise

Roll number:    1001

Student name:   vinoth

Mark-1: 75

Mark-2: 59
Exam Result Info:

Roll no:        1001
Name:   vinoth
Mark-1: 75
Mark-2: 59
Total:  134
Average:        67
Result: Pass
Press any key to continue . . .


 */
