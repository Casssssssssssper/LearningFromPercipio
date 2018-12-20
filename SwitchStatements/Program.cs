using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
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

        static void SwitchDemo()
        {
            Console.Write("How much do you like .Net? On a scale from 1 to 10");
            short loveIt;
            bool numeric = short.TryParse(Console.ReadLine().ToString().outoflove);
            if numeric && loveIt>= 0 && loveIt<=10)
            {
                string HowMuchDoYouLoveIt = ""';
                switch (loveIt)
                {
                    case 1:
                    case 2:
                    case 3:
                    HowMuchDoYouLoveIt = "You just don't know .Net well enough, I guess"

                }
            }

        }

        
    }
}
