using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.Getsetproperties
{
    class CLSpropaa
    {
        private int _rno;
        private string _sname;
        private double _m1 = 0, _m2 = 0;

        public int Rno // Property
        {
            get
            {
                return _rno;
            }

            set
            {
                _rno = value;

            }
        }

        public string Name // Property
        {
            get
            {
                return _sname;
            }

            set
            {
                _sname = value;

            }
        }

        public double M1 // Property
        {
            get
            {
                return _m1;
            }

            set
            {
                _m1 = value;

            }
        }

        public double M2 // Property
        {
            get//read
            {
                return _m2;
            }

            set//write
            {
                _m2 = value;

            }
        }

        public double Total // Property
        {
            get
            {
                return _m1 + _m2;
            }


        }

        public double Average // read only Property
        {
            get //read
            {
                return Total / 2;
            }
        }
        public string Result // Property
        {
            get
            {
                return _m1 > 34.4 && _m2 > 34.4 ? "Pass" : "Fail";
            }
        }
    }

    class CLSpropaaER
    {
        public static void Main()
        {

            CLSpropaa er = new CLSpropaa();


            er.Rno = 1001;
            er.Name = "xx";
            er.M1 = 36.5;
            er.M2 = 80;

            Console.WriteLine(er.Rno);
            Console.WriteLine(er.Name);
            Console.WriteLine(er.M1);
            Console.WriteLine(er.M2);
            Console.WriteLine(er.Total);
            Console.WriteLine(er.Average);
            Console.WriteLine(er.Result);

        }
    }
}
/*
output
1001
xx
36.5
80
116.5
58.25
Pass
*/
