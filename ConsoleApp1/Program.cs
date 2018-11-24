using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double tzua = 0.05;
            double s = 2500;
            double difPerMounth = (tzua / 12)+1;

            for (int i = 0; i < 120; i++)
            {
                s *= difPerMounth;
                s += (2500 - 35);
            }

            Console.WriteLine(s);

            s = 2500;
            difPerMounth = (tzua / 6) + 1;
            for (int i = 0; i < 60; i++)
            {
                s *= difPerMounth;
                s += (5000 - 35);
            }

            Console.WriteLine(s);

            s = 2500;
            difPerMounth = (tzua / 4) + 1;
            for (int i = 0; i < 40; i++)
            {
                s *= difPerMounth;
                s += (7500 - 35);
            }

            Console.WriteLine(s);

            s = 2500;
            double difPer4Mounth = (tzua / 3) + 1;

            for (int i = 0; i < 30 ; i++)
            {
                s *= difPer4Mounth;
                s += (10000 - 35);
            }

            Console.WriteLine(s);


            s = 2500;
            double difPerYear = tzua + 1;

            for (int i = 0; i < 10; i++)
            {
                s *= difPerYear;
                s += (30000 - 35);
            }

            Console.WriteLine(s);


            s = 2500;
            double difPer2Years = (tzua*2) + 1;

            for (int i = 0; i < 5; i++)
            {
                s *= difPer2Years;
                s += (60000 - 35);
            }

            Console.WriteLine(s);

            Random r = new Random();
            s = 2500;
            difPerMounth = 1.01875;
            double ddd = 0;
            int subsum = 0;
            for (int i = 0; i < 40; i++)
            {
                int v = r.Next(0, 6);
                if(i == 3 || i== 7 || i==8 || i==17 || i==21 || i==23 || i==24 ||i == 90)
                {
                    ddd -= difPerMounth;
                    s /= difPerMounth;
                    s += (subsum-35);
                    subsum = 0;
                }
                else
                {
                    ddd += difPerMounth;
                    s *= difPerMounth;
                    subsum += 2500;
                }
               
            }
            s += subsum;
            Console.WriteLine(ddd/40);
            Console.WriteLine(s);

        }
    }
}
