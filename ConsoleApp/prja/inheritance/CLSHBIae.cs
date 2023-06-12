using System;

namespace prja.inheritance
{
    interface ITHBIaa
    {
        void uAuthor();
    }
    interface ITHBIab : ITHBIaa
    {
        void uSum(int x, int y);
        double uMinus(double x, double y);
    }
    interface ITHBIac : ITHBIaa
    {
        int uMultiply(int x, int y);
        void uDivide(double x, double y);
    }
    class CLSHBIad : ITHBIab, ITHBIac
    {
        public CLSHBIad()
        {
            Console.WriteLine("Constructor: CLSHBIad");
        }
        ~CLSHBIad()
        {
            Console.WriteLine("Destructor: CLSHBIad");
        }
        public void uAuthor()
        {
            Console.WriteLine("Develop by RV");
        }
        public void uSum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public double uMinus(double x, double y)
        {
            return x - y;
        }
        public int uMultiply(int x, int y)
        {
            return x * y;
        }
        public void uDivide(double x, double y)
        {
            Console.WriteLine(x / y);
        }

    }


    class CLSHBIae
    {
        public static void Main()
        {
            CLSHBIad ad = new CLSHBIad();
            ad.uAuthor();
            ad.uSum(1, 9);
            Console.WriteLine(ad.uMinus(8, 5));

            Console.WriteLine(ad.uMultiply(2, 7));
            ad.uDivide(20, 3);
        }
    }
}

