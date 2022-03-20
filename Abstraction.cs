using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    //Abstraction-abstract classes and interface
    //Abstract classes - abstract keyword, abstract methods(no implementation) and non abstract methods
    //An instance cannot be created for an abstract class
    //Abstract classes must be inherited and all the abstract methods must be used(implemented) in the derived class


    public abstract class EB_Plan
    {
        protected double rate;//variable
        public abstract void GetRate();//no implementation

        public void calculate(int units)
        {
            Console.WriteLine($"EB amount is : {rate * units}");
        }
    }

    public class EB_Commercial:EB_Plan
    {
        public override void GetRate()
        {
            rate = 10.00;
        }

    }
    public class EB_Domestic : EB_Plan
    {
        public override void GetRate()
        {
            rate = 5.00;
        }

    }


    internal class Abstraction
    {
        public static void Main()
        {
            //Base to Derived
            EB_Plan b;
            b=new EB_Commercial();
            b.GetRate();
            b.calculate(10);
            b=new EB_Domestic();
            b.GetRate();
            b.calculate(5);
        }
    }
}
