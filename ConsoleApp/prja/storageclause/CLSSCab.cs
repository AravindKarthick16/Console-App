using System;

namespace prja.slorageclause

{
    class CLSSCaa
    {
        public int x;
        public static int y;
    }
    class CLSSCab
    {
        public static void Main()
        {
            CLSSCaa a1 = new CLSSCaa();
            CLSSCaa a2 = new CLSSCaa();
            CLSSCaa a3 = new CLSSCaa();

            Console.WriteLine(a1.x);
            Console.WriteLine(a2.x);
            Console.WriteLine(a3.x);

            Console.WriteLine(CLSSCaa.y);

            a1.x = 5;
            a2.x = 7;
            a3.x = 9;
            CLSSCaa.y = 3;

            Console.WriteLine(a1.x);
            Console.WriteLine(a2.x);
            Console.WriteLine(a3.x);
            Console.WriteLine(CLSSCaa.y);
        }
    }
}