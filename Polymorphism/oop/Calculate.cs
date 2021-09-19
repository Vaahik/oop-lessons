using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Calculate
    {
        public void AddNumbers(int a, int b)
        {
            Console.Write("a + b = {0}", a + b);
        }
        public void AddNumbers(int a, int b, int c)
        {
            Console.WriteLine("a + b + c = {0}", a + b + c);
        }
    }
}