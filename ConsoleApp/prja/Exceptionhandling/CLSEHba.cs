using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.Exceptionhandling
{
    class CLSEHba
    {
        public static int withDraw(int deposit, int withDrawAmount)
        {
            if (deposit > withDrawAmount)
            {
                return deposit - withDrawAmount;
            }
            else
            {
                throw new Exception("Invalid transaction");
            }

        }
        public static void Main()
        {
            try
            {
                int ba = withDraw(100, 20);
                Console.WriteLine("Balance Amount: " + ba);

                ba = withDraw(30, 40);
                Console.WriteLine("Balance Amount: " + ba);
            }
            catch (Exception e)
            {
                Console.WriteLine("err: " + e.Message);
            }
        }
    }
}
/*
Output:
Balance Amount: 80
err: Invalid transaction
 */
