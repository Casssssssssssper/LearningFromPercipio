using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, big;
            Console.WriteLine("Enter the first number\t:");
            number1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number\t:");
            number2 = Int16.Parse(Console.ReadLine());
            if (number1 > number2)
            {
                big = number1;
                Console.WriteLine("The first number is greater");
            }
            Console.ReadKey();


        }
    }

    class ConditionalOperatorDemo
    {
        public static void Main()
        {
            int number1, number2, big;
            Console.WriteLine("Enter the first number\t:");
            number1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number\t:");
            number2 = Int16.Parse(Console.ReadLine());
            if (number1 > number2)
            {
                big = number1;
            }
            else
            {
                big = number2;
            }
            Console.WriteLine("The greater number is " + big);
            Console.ReadKey();
        }
    }

    class IfElseStatements
    {
        static void Main(string[] args)
        {
            float a, b, c, d, r1, r2;
            Console.WriteLine("\nEnter the first number\t:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the second number\t:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the third number\t:");
            c = float.Parse(Console.ReadLine());
            d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                Console.WriteLine("roots are imaginary");
            }
            else if (d > 0)
            {
                r1 = (float)((-1 * b) + Math.Sqrt(d)) / (2 * a);
                r2 = (float)((-1 * b) - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("roots are real and distinct\nFirst Root\t:{0}\nSecondRoot\t:{ 1}", r1, r2);
                }
            else
            {
                r1 = (-1 * b) / (2 * a);
                r2 = r1;
                Console.WriteLine("roots are real and equal\nRoot(s)\t:{0}", r1);
            }
            Console.ReadKey();
        }
    }
}
