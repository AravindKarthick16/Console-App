using System;

namespace prja
{
    class CLSEBaa
    {
        public static void Main()
        {
            int cid = 0;
            Console.Write("\nConsumer ID: ");
            int.TryParse(Console.ReadLine(), out cid);

            int pread = 0;
            Console.Write("\nConsume Previous Reading: ");
            int.TryParse(Console.ReadLine(), out pread);

            int cread = 0;
            Console.Write("\nConsume Current Reading: ");
            int.TryParse(Console.ReadLine(), out cread);

            if (cread < pread)
            {
                Console.WriteLine("\nInvalid Reading...");
                return;
            }
            ConsumerCategory cc = ConsumerCategory.Commercial;
            Console.Write("\nConsumer category");
            Console.Write("\n0. Agriculture");
            Console.Write("\n1. Domestic");
            Console.Write("\n2. Commercial");
            Console.Write("\n[0, 1 or 2]: ");

            int i = 2;
            int.TryParse(Console.ReadLine(), out i);

            if (Enum.IsDefined(typeof(ConsumerCategory), i) == false)
            {
                Console.WriteLine("Invalid: Consumer Category");
                return;
            }

            int nread = cread - pread;

            if (nread < 0)
            {
                Console.WriteLine("Invalid: Net reading");
                return;
            }
            int cuu100 = 0, cuu200 = 0, cuu400 = 0, cua400 = 0;

            if (nread > 400)
            {
                cuu100 = 100;
                cuu200 = 100;
                cuu400 = 200;
                cua400 = nread - 400;
            }
            else if (nread > 200)
            {
                cuu100 = 100;
                cuu200 = 100;
                cuu400 = nread - 200;
            }
            else if (nread > 100)
            {
                cuu100 = 100;
                cuu200 = nread - 100;
            }
            else if (nread > 0)
            {
                cuu100 = nread;
            }
            double puau100 = 0, puau200 = 0, puau400 = 0, puaa400 = 0;
            double cuau100 = 0, cuau200 = 0, cuau400 = 0, cuaa400 = 0;
            double mc = 0, taxp = 0, taxa = 0, npay = 0;

            cc = (ConsumerCategory)i;
            if (cc == ConsumerCategory.Agriculture)
            {
                puau100 = 0.25;
                puau200 = 0.50;
                puau400 = 1.50;
                puaa400 = 2.00;
                mc = 12.50;
                taxp = 2.5;
            }
            else if (cc == ConsumerCategory.Domestic)
            {
                puau100 = 0.50;
                puau200 = 1.00;
                puau400 = 3.00;
                puaa400 = 6.00;
                mc = 25.00;
                taxp = 5.0;
            }
            else if (cc == ConsumerCategory.Commercial)
            {
                puau100 = 1.00;
                puau200 = 2.00;
                puau400 = 6.00;
                puaa400 = 10.00;
                mc = 200.00;
                taxp = 7.5;
            }
            cuau100 = puau100 * cuu100;
            cuau200 = puau200 * cuu200;
            cuau400 = puau400 * cuu400;
            cuaa400 = puaa400 * cua400;

            taxa = (taxp / 100) * cuaa400;
            npay = cuau100 + cuau200 + cuau400 + cuaa400 + taxa + mc;

            Console.WriteLine("Consume Net Reading: " + nread);
            if (cuau100 > 0)
            {
                Console.WriteLine("Per unit amount up to 100: " + puau100);
                Console.WriteLine("Consume unit up to 100: " + cuu100);
                Console.WriteLine("Consume unit amount up to 100: " + cuau100);
            }
            if (cuau200 > 0)
            {
                Console.WriteLine("Per unit amount up to 200: " + puau200);
                Console.WriteLine("Consume unit up to 200: " + cuu200);
                Console.WriteLine("Consume unit amount up to 200: " + cuau200);
            }
            if (cuau400 > 0)
            {
                Console.WriteLine("Per unit amount up to 400: " + puau400);
                Console.WriteLine("Consume unit up to 400: " + cuu400);
                Console.WriteLine("Consume unit amount up to 400: " + cuau400);
            }
            if (cuaa400 > 0)
            {
                Console.WriteLine("Per unit amount up to 400: " + puau400);
                Console.WriteLine("Consume unit up to 400: " + cuu400);
                Console.WriteLine("Consume unit amount above 400: " + cuaa400);

                Console.WriteLine("Tax amount: " + taxa);
            }
            Console.WriteLine("Meter charge: " + mc);
            Console.WriteLine("Net pay: " + npay);






        }
    }
}
