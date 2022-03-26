﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    internal class ConstructorDestructor
    {
        public static void Main()
        {
            Addition7 addition = new Addition7();//Default Constructor is called
            Addition7 addition2 = new Addition7(10);//Constructor (1 int parameter)
            Addition7 addition3 = new Addition7(20, 30);//Constructor (2 int parameters)
        }
    }
    public class Addition7
    {
        //Constructor-special method-same name(class name),no return type,automatically instantiated
        //Constructor Overloading
        public Addition7()
        {
            Console.WriteLine("Default Constructor");
        }
        public Addition7(int a)
        {
            Console.WriteLine(a+a);
        }
        public Addition7(int a,int b)
        {
            Console.WriteLine(a + b);
        }

        //Garabage Collection- automatically memory is set free
        //Destructor- same name(class name)-one destructor per class
        //Destructor-no return type,no access specifier
        //Destructor-prefixed with a ~Tilde symbol


        //Destructor-Finalize(),Dispose()
        //Finalize()-Whenever a destructor is called-automatically finalize() is called internally
        ~Addition7()
        {
            Console.WriteLine("I am a Destructor");
        }

        //What happens when destructor called internally
        //    protected override void Finalize()
        //{
        //    try
        //    {

        //    }
        //    catch
        //    {
        //            Base.Finalize();
        //    }
        //}

    }
}
