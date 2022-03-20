using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    //Method Overriding - Virtual Functions
    class Base
    {
        public virtual void msg()
        {
            Console.WriteLine("Base Class");
        }
    }
    class Derived:Base
    {
        public override void msg()
        {
            //base.msg();
            Console.WriteLine("Derived Class");
        }
    }
    internal class Overriding
    {
        public static void Main()
        {
            Derived d = new Derived();
            d.msg();

        }
                
    }
}
