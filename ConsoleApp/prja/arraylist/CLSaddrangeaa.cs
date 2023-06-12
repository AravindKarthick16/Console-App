using System;
using System.Collections;

namespace prja.arraylist
{
    class CLSaddrangeaa
    {
        public static void Main()
        {
            ArrayList ALObja = new ArrayList();
            ALObja.Add("Box");
            ALObja.Add(11);

            ArrayList ALObjb = new ArrayList();
            ALObjb.Add(4.2);
            ALObjb.Add(true);

            ALObja.AddRange(ALObjb);
            foreach (var v1 in ALObja)
                Console.WriteLine(v1);
        }
    }
}
/*
Box
11
4.2
True 
 */
