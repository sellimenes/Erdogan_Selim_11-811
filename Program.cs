using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1==1)
            {
                Console.WriteLine("Welcome to Simple Calculator v0.1");
                Console.Write("Please enter first number : ");
                int numa = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter second number : ");
                int numb = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter 1 for addition, enter 2 for minus, enter 3 multiply, enter 4 for divide");
                Console.Write("Please enter your operation : ");
                int sol = Convert.ToInt32(Console.ReadLine());

                switch (sol)
                {
                    case 1:
                        Console.Write("Your result is : ");
                        Console.WriteLine(numa + numb);
                        break;
                    case 2:
                        Console.Write("Your result is : ");
                        Console.WriteLine(numa - numb);
                        break;
                    case 3:
                        Console.Write("Your result is : ");
                        Console.WriteLine(numa * numb);
                        break;
                    case 4:
                        Console.Write("Your result is : ");
                        Console.WriteLine(numa / numb);
                        break;
                }

            }
        }
    }
}
