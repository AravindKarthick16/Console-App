using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.accessspecifier
{
    class CLSASba
    {
        private int x;

        public void setData(int i)
        {
            x = i;
        }

        public void showData()
        {
            Console.WriteLine("x: " + x);
        }

    }

    class CLSASbb
    {
        public static void Main()
        {
            CLSASba ba = new CLSASba();

            ba.setData(5);

            ba.showData();
        }
    }
}
