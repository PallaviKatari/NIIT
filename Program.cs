using System;  //Basic Namespace->datatypes,arrays,strings

//create a namespace -> collection of classes
namespace NIIT
{
    /// <summary>
    /// Basic C# Program to display a message
    /// </summary>
    //create a class
    public class Sample
    {
        /// <summary>
        /// Main method using WriteLine
        /// </summary>
        //Functions->Methods
        //Main()->Entry Point
        public static void Main(string[] args)
        {
            //Console->class
            //WriteLine->Method
            Console.WriteLine("Welcome to C# Console Application");

            //Datatypes
            //Value Type datatypes - > single value
            //int,float,double,string,bool,char
            int a = 10;
            Console.WriteLine(a);
            float b= 12.56f;
            Console.WriteLine(b);
            double c = 12.675438;
            Console.WriteLine(c);
            char d = 'N';
            Console.WriteLine(d);
            string e = "NIIT";
            Console.WriteLine(e);
            bool f = true;
            Console.WriteLine(f);

            //Typecasting 
            double g = 3.14;
            Console.WriteLine(g);
            int i = (int)g;
            Console.WriteLine("Explicit Typecast: " + i);
            Console.WriteLine("Convert to Char: " + Convert.ToChar(i));
            Console.WriteLine("Convert to Char: " + Convert.ToChar(65));
            Console.ReadLine();
            //Type Conversion
            Console.WriteLine("Type Conversion: "+ Convert.ToInt32(g));
            Console.ReadLine();
            
            //Get Trainee Details and Display
            string name;
            int id;
            Console.WriteLine("Trainee Details");
            Console.WriteLine("Enter your name");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            name = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("Enter your ID");
            id=Convert.ToInt32(Console.ReadLine());
            //id = int.Parse(id);
            Console.WriteLine("Name is: "+ name);
            Console.WriteLine("ID is: "+ id);

            //String Interpolation/Formatting
            Console.WriteLine("My name is: {0} and my Id is: {1}",name,id);
            Console.WriteLine("My ID is: {1} and My Name is: {0}", name, id);
            Console.WriteLine("{0} is a very good developer.\n{0} resides in Bangalore", name);

        }
        /// <summary>
        /// Addition OPeration
        /// </summary>
        public void Add()
        {

        }
    }
}
//Short cut key to comment multiple lines-> ctrl+K+C
//Short cut key to uncomment multiple lines-> ctrl+K+U