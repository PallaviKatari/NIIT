using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    //public,private,protected,internal,protected internal
    //Classes,Objects,Abstraction,Encapsulation,Polymorphism,Inheritance
    public class AccessSpecifier
    {
        //private access specifier 
        private int id;
        private string name;

        //Properties-get(read) and set(write)
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
         public void Display()
        {
            Console.WriteLine($"ID is:{id} and Name is:{name}");
        }
    }
    public class Encapsulation
    {
        public static void Main()
        {
            AccessSpecifier sample = new AccessSpecifier();
            sample.Id = 100;
            sample.Name = "John";
            sample.Display();
            //sample.id = 101;
            //sample.name = "Peter";
            sample.Display();
        }
    }
}
