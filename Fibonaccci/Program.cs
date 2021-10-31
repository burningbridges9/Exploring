using System;

namespace Fibonaccci
{
    class Program
    {
        static double FibAlgo(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                //double[] arr = new double[n];
                //arr[0] = 0; arr[1] = 1;
                //for (int i = 2; i != n; i++)
                //{
                //    arr[i] = arr[i - 1] + arr[i - 2];
                //}
                //return arr[n-1];

                int prevprev = 0;
                int prev = 1; int res = 0;
                for (int i = 1; i != n; i++)
                {
                    res = prev + prevprev;
                    prevprev = prev;
                    prev = res;
                }
                return res;
            }
        }

        static double FibAlgoRec(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {

                return (FibAlgoRec(n - 1) + FibAlgoRec(n - 2));
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            //double res1 = FibAlgoRec(n); //fibAlgo(n);
            double res2 = FibAlgo(n);
            //Console.WriteLine("fibRec({0}) = {1}", n, res1);
            Console.WriteLine("fib({0}) = {1}", n, res2);
            Console.ReadLine();
        }
    }
}
