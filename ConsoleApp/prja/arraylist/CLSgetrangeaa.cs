using System;
using System.Collections;

namespace prja.arraylist
{
    class CLSgetrangeaa
    {
        public static void Main()
        {
            ArrayList ALObja = new ArrayList();
            ALObja.Add("Box");
            ALObja.Add(11);
            ALObja.Add(11);
            ALObja.Add(true);

            ArrayList ALObjb = ALObja.GetRange(2, 2);
            foreach (var v1 in ALObjb)
            Console.WriteLine(v1);
        }
    }
}
/*
 11
True
 */
