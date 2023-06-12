using System;

namespace prja.inheritance
{
    class CLSSIaa
    {
        public CLSSIaa()
        {
            Console.WriteLine("Constructor: CLSSIaa");
        }
        ~CLSSIaa()
        {
            Console.WriteLine("Destructor: CLSSIaa");
        }
    }
    class CLSSIab : CLSSIaa
    {
        public CLSSIab()
        {
            Console.WriteLine("Costructor: CLSSIab");
        }
        ~CLSSIab()
        {
            Console.WriteLine("Destructor: CLSSIab");
        }
    }
    class CLSSIac
    {
        public static void Main()
        {
            new CLSSIab();
        }
    }
}