using System;
using System.Collections;

namespace prja.BitAray
{
    class CLSbitarrayab
    {
        static void Main()
        {
            BitArray BAobj = new BitArray(6);
            BAobj[0] = true;
            BAobj[2] = true;
            BAobj.Set(5, true);
            Console.WriteLine(BAobj.Count);

            int i = 0;
            foreach(bool b in BAobj)
            {
                if (b)
                    i++;
            }
            Console.WriteLine(i);

        }

    }
}
