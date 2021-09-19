using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Users
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Base Class");
        }
    }
    public class Details: Users
    {
        public override void GetInfo()
        {
            Console.WriteLine("Derived Class");
        }

    }
}