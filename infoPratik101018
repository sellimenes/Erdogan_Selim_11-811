using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infoPratik101018
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Enter a number : ");
            int a = int.Parse(Console.ReadLine());
            int[] number = new int[a];
            int min, max;

            for (int i = 0; i < a; i++)
            {
                number[i] = rnd.Next(1, 100);
                Console.Write(number[i] + " - ");
                
            }
            min = number[0];
            max = number[0];
            for (int i = 1; i < number.Length; i++)
            {
                if (min > number[i])
                    min = number[i];
                if (max < number[i])
                    max = number[i];
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Min. number : " +min);
            Console.WriteLine("Max number : " +max);

            int calc = 1;

            Console.WriteLine("  ");
            Console.WriteLine("Minimum number (" +min+ ") used " +calc+ " times." );
            Console.WriteLine("Maximum number (" + max + ") used " + calc + " times.");
            Console.WriteLine(" ");

            Array.Sort(number);
            Console.Write("Beginning from min. : ");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " - ");
            }
            Array.Reverse(number);
            Console.WriteLine(" ");
            Console.Write("Beginning from max. : ");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " - ");
            }
         
            Console.ReadKey();
        }
    }
}
