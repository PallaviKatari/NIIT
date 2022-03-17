using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    //class Addition
    public class Addition
    {
        //variables a and b
        int a;
        int b;
        //Method Add
        //Instance Method with no parameter
        public void Add()
        {
            a = 10;
            b = 20;
            a += b;
            Console.WriteLine("Result: " + a);
        }
        //Instance Method with 2 int parameters
        public void Sub(int x,int y)
        {
            Console.WriteLine(x - y);
        }
        //Instance Method with 2 parameters(int,string)
        public void GetDetails(int ID,string Name)
        {
            Console.WriteLine("ID is: " + ID);
            Console.WriteLine("Name is: " + Name);
        }
        //Static Method
        public static void Sample2()
        {
            Console.WriteLine("I am a Static Method outside the Main() Class");
        }
        
    }
    internal class Methods
    {
        public static void Main()
        {
            //creating an instance for Addition class to access the method Add()
            Addition add=new Addition();
            //Instance Methods outside the class
            add.Add();
            add.Sub(30, 10);
            add.GetDetails(101, "John");
            //Static method outside the class
            Addition.Sample2();
            //Instance Method inside the class
            Methods methods = new Methods();
            methods.Sample();
            //Static method within the class
            Sample1();
            
        }
        //Instance Method
        public void Sample()
        {
            Console.WriteLine("I am a Method which is created in the same class where the Main()");
        }

        //Static Method
        public static void Sample1()
        {
            Console.WriteLine("I am a Static Method");
        }

    }
}
