using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push("First Element");
            s.Push('S');
            s.Push(3);
            Console.WriteLine("Elements");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Element\t:" + s.Pop().ToString());
            }
            Console.ReadKey();

            /*
             
            push(item)
        {
            if (TOP != Max - 1)
            {
                TOP++;
                stack[TOP] = item;
            }
            else
            {
                print "OVERFLOW";
            }
        }

        int pop()
        {
            if (TOP != -1)
            {
                return (stack[TOP--]);
            }
            else
            {
                print "UNDERFLOW";
                return -1;
            }
        }


            */
        }


    }
}
/*
Elements      : 3
Elements      : S
Elements      : First Element
*/
