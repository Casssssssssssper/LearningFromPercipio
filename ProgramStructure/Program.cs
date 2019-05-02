using System;

namespace ProgramStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hi there");
            Console.ReadKey();

            Console.WriteLine("This moment belongs to me");
        }

        interface student
        {
            void getdata()
            {
                // get data 
                Console.WriteLine("Enter the first number\t:");
                number1 = int.Parse(Console.ReadLine());


                int number1;
                try
                {
                    Console.WriteLine("Enter the first number\t:");
                    number1 = int.Parse(Console.ReadLine());
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error" + e.ToString());
                    Console.ReadKey();
                }
            }

        }

        // System.Data.IDbConnection OleDBConnection () { }

    }
}
