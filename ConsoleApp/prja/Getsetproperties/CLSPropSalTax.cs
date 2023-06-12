using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prja.Getsetproperties
{
    class CLSPropSalTaxaa
    {
        int _eid;
        String _Ename;
        double _esal = 0;
        double _tax10 = 0;
        double _tax20 = 0;
        double _tax30 = 0;
        double _npay = 0;


        public int ID
        {
            get
            {
                return _eid;
            }

            set
            {
                _eid = value;
            }
        }

        public string Name
        {
            get
            {
                return _Ename;
            }

            set
            {
                _Ename = value;
            }
        }

        public double Salary
        {
            get
            {

                return _esal;
            }

            set
            {
                _esal = value;
            }
        }

        public double Tax10
        {
            get
            {
                if (_esal > 100000)
                {
                    _tax10 = 25000;
                }

                else if (_esal > 500000)
                {
                    _tax10 = 25000;

                }

                else if (_esal > 250000)
                {
                    _tax10 = (_esal - 250000) * 10.0 / 100;

                }

                return _tax10;
            }

        }


        public double Tax20
        {
            get
            {
                if (_esal > 100000)
                {

                    _tax20 = 100000;
                }

                else if (_esal > 500000)
                {

                    _tax20 = (_esal - 500000) * 20.0 / 100;

                }



                return _tax20;
            }

        }

        public double Tax30
        {
            get
            {
                if (_esal > 100000)
                {
                    _tax30 = (_esal - 1000000) * 30.0 / 100;
                }



                return _tax30;
            }

        }

        public double NetPay
        {
            get
            {

                _npay = Salary - (Tax10 + Tax20 + Tax30);


                return _npay;
            }

        }
    }
    class CLSPropSalTax
    {
        public static void Main()
        {
            CLSPropSalTaxaa ST = new CLSPropSalTaxaa();

            ST.ID = 1001;
            ST.Name = "xx";
            ST.Salary = 1000001;

            Console.WriteLine("ID    : \t" + ST.ID);
            Console.WriteLine("Name  : \t" + ST.Name);
            Console.WriteLine("Salary: \t" + ST.Salary);
            Console.WriteLine("TAX10%: \t" + ST.Tax10);
            Console.WriteLine("TAX20%: \t" + ST.Tax20);
            Console.WriteLine("TAX30%: \t" + ST.Tax30);
            Console.WriteLine("Npay  : \t" + ST.NetPay);
        }

    }
}
/*
 output
 ID    :         1001
Name  :         xx
Salary:         1000001
TAX10%:         25000
TAX20%:         100000
TAX30%:         0.3
Npay  :         875000.7
*/
