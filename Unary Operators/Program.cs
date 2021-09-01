using System;

namespace UnaryOperators
{
    class UnaryOperator
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 3;

            b = a++;
            Console.WriteLine("The value of b is" + b);
            Console.WriteLine("The  Post-increment value of a" + a);


            b = ++a;
            Console.WriteLine("The value of b is" + b);
            Console.WriteLine("The Pre-increment value of a " + a);


            b = a--;
            Console.WriteLine("The value of b is" + b);
            Console.WriteLine("The  Post-Decrement value of a " + a);


            b = --a;
            Console.WriteLine("The value of b is" + b);
            Console.WriteLine("The Pre-Decrement value of a " + a);

        }
    }
}

