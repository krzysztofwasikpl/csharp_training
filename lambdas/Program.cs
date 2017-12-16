using System;

namespace lambdas
{
    class MainClass
    {
        public delegate int MyDelegate(int x);

        public static void Main(string[] args)
        {
            Console.WriteLine("project: lambdas");

            MyDelegate foo = (x) => x * x ;
            Console.WriteLine("foo 1 for x=2 is " + foo(2));

            foo = (x) => 3 * x;
            Console.WriteLine("foo 2 for x=2 is " + foo(2));

        }
    }
}
