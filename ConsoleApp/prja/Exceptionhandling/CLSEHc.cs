using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.Exceptionhandling
{
    class CLSEHc
    {
        public CLSEHc()
        {
            Console.WriteLine("Constructor: CLSEHc");
        }

        ~CLSEHc()
        {
            Console.WriteLine("Destructor: CLSEHc");
        }
    }
    class CLSEHac
    {
        public static void Main()
        {
            try
            {
                CLSEHc ehc = new CLSEHc();
                Console.WriteLine("allocate memory to object: ehc");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("block: catch");
            }
            finally
            {
                Console.WriteLine("Deallocate memory to object: ehc");
            }

        }
    }
}
/*
Output:
Constructor: CLSEHc
allocate memory to object: ehc
Deallocate memory to object: ehc
Destructor: CLSEHc  
 */
