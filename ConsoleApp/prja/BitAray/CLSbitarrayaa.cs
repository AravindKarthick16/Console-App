using System;
using System.Collections;


namespace prja.BitAray
{
    class CLSbitarrayaa
    {
        public static void Main()
        {
            bool[] b = new bool[4];
            b[0] = true;
            b[2] = true;

            BitArray BAObj = new BitArray (b);
            foreach (bool b2 in BAObj)
             Console.WriteLine(b2);
        

        }
    }
}

/*
 True
False
True
False
 */
