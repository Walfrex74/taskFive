using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10;
            double n = 1;
            double res = 0;
            Console.WriteLine(Task_5(x, n, res));

            Console.ReadKey();
        }

        static double Task_5(double x, double n, double res)
        {
            for (n = 1; n < 10; n++)
            {
                res = Math.Pow(x, n) / (n + x);
            }
            return res;
        }
    }
}