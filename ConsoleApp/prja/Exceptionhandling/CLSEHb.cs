using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.Exceptionhandling
{
    class CLSEHb
    {
        public CLSEHb()
        {
            Console.WriteLine("Constructor: CLSEHb");
        }

        ~CLSEHb()
        {
            Console.WriteLine("Destructor: CLSEHb");
        }
    }
    class CLSEHab
    {
        public static void Main()
        {
            try
            {
                CLSEHb ehb = new CLSEHb();
                Console.WriteLine("allocate memory to object: ehb");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("block: catch");
            }
            Console.WriteLine("Deallocate memory to object: ehb");
        }
    }
}