﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infoPratik310
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Bir sayı giriniz : ");
                double x = double.Parse(Console.ReadLine());
                double y , y1;
                if (x > 1)
                    y = x / 3;
                else
                    y = x;
                for(int k= 1; k<10000; k++)
                {
                    y1 = y - (y - x / (y * y)) / 3;
                    y = y1;
                }
                Console.Write("Sayının küpkökü : ");
                Console.WriteLine(y);

            }
        }
    }
}