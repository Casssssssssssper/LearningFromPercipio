using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningFromPercipio
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
        static void AnonMethods()
        {
            // Add an anonymous method
            System.Threading.Thread t1 = new System.Threading.Thread(delegate ()
            {
                System.Console.Write("Hello");
                System.Console.WriteLine("World");
            });

            t1.Start();

            ResetConsole("And with the MathDelegate");
            MathDelegate anotherDelegateInstance = new MathDelegate(delegate (int x, int y)
                {
                    return (decimal)(x / y);
                });
            decimal result = anotherDelegateInstance.invoke(3333, 11);
            Console.WriteLine("MathDelegate call: {0}", result);
        }
    }
}
