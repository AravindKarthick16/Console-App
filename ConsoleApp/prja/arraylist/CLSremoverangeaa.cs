using System;
using System.Collections;

namespace prja.arraylist
{
    class CLSremoverangeaa
    {
        public static void Main()
        {
            ArrayList ALObj = new ArrayList();
            ALObj.Add("Box");
            ALObj.Add(11);
            ALObj.Add(11);
            ALObj.Add(true);

            ALObj.RemoveRange(1, 2);
            foreach (var v1 in ALObj)
            Console.WriteLine(v1);

        }
    }
}
/*
Box
True  
 */
