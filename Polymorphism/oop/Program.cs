using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Compile Time Polymorphism--");
            Calculate c = new Calculate();
            c.AddNumbers(1, 3);
            c.AddNumbers(1, 4, 7);
            Console.WriteLine("--Run Time Polymorphism--");
            Details details = new Details();
            details.GetInfo();
            Users users = new Users();
            users.GetInfo(); 
        }
    }
}