using System;

namespace prja.sealed_class
{
    class CLSSEAaa
    {
        public CLSSEAaa()
        {
            Console.WriteLine("Constructor: CLSSEAaa");
        }
        ~CLSSEAaa()
        {
            Console.WriteLine("Destructor: CLSSEAaa");
        }
    }
    sealed class CLSSEAab : CLSSEAaa
    {
        public CLSSEAab()
        {
            Console.WriteLine("Destructor : CLSSEAab");
        } 
           
    }
    /*class CLSSEAac : CLSSEAab
    {
        public CLSSEAac()
        {
           Console.WriteLine("Constructor: CLSSEAac");
        }
        */
        class CLSSEALEDaa
        {
            public static void Main()
            {
                new CLSSEAab();
            }
        }
     
}
