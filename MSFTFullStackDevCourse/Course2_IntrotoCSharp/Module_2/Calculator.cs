using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2_IntrotoCSharp.Module_2
{
    class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void Run()
        {
            int num1 = 5;
            int num2 = 10;
            if (num1 > 0 && num2 > 0)
            {
                int result = Add(num1, num2);
                Console.WriteLine("The Sum is " + result);
            }
        }
    }
}
