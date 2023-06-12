using System;

namespace prja.accessspecifier
{
    class CLSASda
    {
        protected int x;
    }

    class CLSASdb : CLSASda
    {
        public void showData()
        {
            Console.WriteLine(x);
        }
    }

    class CLSASdc
    {
        public static void Main()
        {
            CLSASdb db = new CLSASdb();
            db.showData();
        }
    }
}