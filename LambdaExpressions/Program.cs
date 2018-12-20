using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
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

        static void LambdaLambdaLambda()
        {
            ClearInvocationList();

            // Variable = (( parameter(s) => { statement(s)   [n]   return results);}

            MyMathDelegate += ((param1In, param2In) => { return param1In * param2In; });

            int x = 55;
            int y = 77;

            Console.WriteLine("With params {0} - {1}. the result of {2} is {3}", x,y.);
        }
    }
}
