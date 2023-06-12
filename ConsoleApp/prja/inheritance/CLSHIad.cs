using System;


namespace prja.inheritance
{
    class CLSHIaa
    {
        public CLSHIaa()
        {
            Console.WriteLine("Constructor: CLSHIaa");
        }
        ~CLSHIaa()
        {
            Console.WriteLine("Destructor: CLSHIaa");
        }
    }
    class CLSHIab : CLSHIaa
    {
        public CLSHIab()
        {
            Console.WriteLine("Constructor: CLSHIab");
        }
        ~CLSHIab()
        {
            Console.WriteLine("Destrustor: CLSHIab");
        }
    }

    class CLSHIac : CLSHIaa
    {
        public CLSHIac()
        {
            Console.WriteLine("Constructor: CLSHIac");
        }
        ~CLSHIac()
        {
            Console.WriteLine("Destrustor: CLSHIac");
        }
    }
    class CLSHIad
    {
        public static void Main()
        {
            new CLSHIab();
            new CLSHIac();
        }
    }

}