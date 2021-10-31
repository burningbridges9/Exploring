using System;

namespace Euclid
{
    class Program
    {
        static double Euclid(double a, double b)
        {
            if (a == 0)
            {
                return b;
            }
            if (b == 0)
            {
                return a;
            }
            else
            {
                if (a >= b)
                {
                    return Euclid(a % b, b);
                }
                else
                {
                    return Euclid(a, b % a);
                }
            }
        }

        static void Main(string[] args)
        {
            double res = Euclid(15, 10);
            Console.WriteLine("res = {0}", res);
            Console.ReadLine();
        }
    }
}
