using System;


namespace prja.inheritance
{
    class CLSMLIaa
    {
        public CLSMLIaa()
        {
            Console.WriteLine("Constructor: CLSMLIaa");
        }
        ~CLSMLIaa()
        {
            Console.WriteLine("Destructor: CLSMLIaa");
        }
    }
    class CLSMLIab : CLSMLIaa
    {
        public CLSMLIab()
        {
            Console.WriteLine("constructor: CLSMLIab");
        }
        ~CLSMLIab()
        {
            Console.WriteLine("Destrustor: CLSMIab");
        }
    }

    class CLSMLIac : CLSMLIab
    {
        public CLSMLIac()
        {
            Console.WriteLine("constructor: CLSMLIac");
        }
        ~CLSMLIac()
        {
            Console.WriteLine("Destrustor: CLSMIac");
        }
    }
    class CLSMLIad
    {
        public static void Main()
        {
            new CLSMLIac();
        }
    }

}