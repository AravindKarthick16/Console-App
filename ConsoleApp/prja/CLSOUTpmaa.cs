using System;

namespace prja
{
    class CLSOUTpmaa
    {
        public static void uSum(int i, int j, out int k)
        {
            k = i + j;
        }
        public static void uFLNames(string fullname, out string fname, out string Lname)
        {
            int bsi = fullname.IndexOf(" ");
            if (bsi == -1)
            {
                fname = fullname;
                Lname = null;
                return;
            }
            fname = fullname.Substring(0, bsi).Trim();
            Lname = fullname.Substring(bsi).Trim();
        }
        public static void Main()
        {
            int x = 0;
            uSum(2, 5, out x);
            Console.WriteLine(x);
            string fullname = "raja raghu raman", sonName = null, fatherName = null;
            uFLNames(fullname, out sonName, out fatherName);
            Console.WriteLine(sonName);
            Console.WriteLine(fatherName);
        }
    }
}
