﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            int[] values = new int[10];

            Console.WriteLine("Задача 5: " + Task_5(ref x, ref n, ref res));
            Console.WriteLine("Задача 10: ");
            Task_10(values);

            Console.ReadKey();
        }

        static double Task_5(ref double x, ref double n, ref double res)
        {
            for (n = 1; n < 10; n++)
            {
                res = Math.Round(Math.Pow(x, n) / (n + x), 2); 
            }
            return res;
        }

        static void Task_10(int[] values)
        {
            bool p = true;
            while(p == true)
            {
                Console.WriteLine("Введите значения массива: ");
                try
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        values[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    p = false;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите числа!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
     
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < 0)
                {
                    values[i] = Convert.ToInt32(Math.Pow(values[i], 3));
                }
                else if (values[i] > 0)
                {
                    values[i] = Convert.ToInt32(Math.Pow(values[i], 2));
                }
            }

            for (int i = 0; i < values.Length; i++) 
            {
                Console.WriteLine(values[i]);
            }
        }
    }
}