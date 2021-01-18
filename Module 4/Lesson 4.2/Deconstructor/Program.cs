using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstructor
{
    class Test
    {
        private int order;

        public Test()
        {
            Console.WriteLine("Calling the default Constructor");
        }
        public Test(int x)
        {
            Console.WriteLine("Calling the one parameter Constructor");
            order = x;
        }
        public Test(int x, int y)
        {
            Console.WriteLine("Calling the two parameter Constructor");
        }
        ~Test()
        {
            Console.WriteLine("Calling the Deconstructor with value: "+order);
        }
        class Program
        {
            static void Function()
            {
                //These will be out of scope, however compiler will not release them immedidately, however, if placed inside main, they will not go out of scope.
                Test obj1 = new Test(1);
                Test obj2 = new Test(2);
                Test obj3 = new Test(3);
                Test obj4 = new Test(4);
                Test obj5 = new Test(5);
            }
            static void Main(string[] args)
            {
                Function();

                GC.Collect(); /*This method (Garbage Collector) will force the compiler to release them immediately and will release in random order, no way to control order they will
                                be released.*/  
                Console.Read();
            }
        }
        
    }
}
