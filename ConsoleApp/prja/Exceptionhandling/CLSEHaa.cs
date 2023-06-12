using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.Exceptionhandling
{
    class CLSEHaa
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("block: Try");
            }
            catch (Exception)
            {
                Console.WriteLine("block: Catch");
            }
            finally
            {
                Console.WriteLine("block: Finally");
            }
            try
            {
                Console.WriteLine("block: Try");
                throw new Exception("user-defined error message");
            }
            catch (Exception e)
            {
                Console.WriteLine("block: Catch,err: " + e.Message);
            }
            finally
            {
                Console.WriteLine("block: Finally");
            }
            try
            {
                int age = 18;
                if (age > 18)
                {
                    Console.WriteLine("age category: Teenage");
                }
                else
                {
                    throw new Exception("Adult");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("err: " + e.Message);
            }
            finally
            {
                Console.WriteLine("block: Finally");
            }

        }
    }
}

/*
 block: Try
block: Finally
block: Try
block: Catch,err: user-defined error message
block: Finally
err: Adult
block: Finally
 */
