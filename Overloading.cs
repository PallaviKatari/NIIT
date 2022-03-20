using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    //Polymorphism- Compile time and Runtime
    //Method Overloading and Method overriding
    //Polymorphism - Many Forms 
    //Method Overloading-add()->the same method can be used in many ways
    //Rules-differ in no of parameters,sequence,datatype

    public class Operators1
    {
        public int a;
        public int b;
        //no parameters
        public void calculate()
        {
            a = 2;
            Console.WriteLine("Square is:{0}", a*a);
        }
        //one parameter
        public void calculate(int a)
        {
            Console.WriteLine("Cube is:{0}", a * a * a);
        }
        //2 parameters of int
        public void calculate(int a,int b)
        {
            Console.WriteLine("Sum is:{0}",a+b) ;
        }
        //2 parameters of double
        public void calculate(double a,double b)
        {
            Console.WriteLine("Divided value is:{0}", a / b);
        }
        //2 parameters int and string
        public void details(int id,string name)
        {
            Console.WriteLine($"ID is {id} and Name is {name}");

        }
        //2 parameters string and int
        public void details(string name, int id)
        {
            Console.WriteLine($"Name is {name} and ID is {id}");

        }
    }
    internal class Overloading
    {
        public static void Main()
        {
            Operators1 operators = new Operators1();
            operators.calculate();
            operators.calculate(10);
            operators.calculate(10,10);
            operators.calculate(10.5, 2);
            operators.details(10, "John");
            operators.details("Sam", 20);
        }
    }
}
