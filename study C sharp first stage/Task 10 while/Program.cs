﻿/*
Խնդիր_10:
Տրված է N բնական թիվը։ Հաշվել N2 + (N + 1)2 + (N + 2)2 + … + (2·N)2 գումարը։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int n = 0;
            while (n<=num)
             {
                sum += (num + n) * (num + n);
                n++;
             }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
