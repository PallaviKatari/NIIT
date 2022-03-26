using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    //Interface- keyword-group of abstract methods and properties-
    //implemented in the derived classes

    //Interface-no variables/fields
    //Interface-Complete Abstraction- Security
    //C#-Multiple Inheritance is not supported - overcome by multiple interface
    interface ICourse
    {
        //abstract property
        string Name { get; set; }
        //abstract method
        //Method Declaration
        void Details();
    }
    interface ICourseList
    {
        void CourseDescription();
    }
    //implement an interface
    class Institution:ICourse,ICourseList
    {
        public string Name { get; set; }

        //Method Definition
        public void Details()
        {
            Console.WriteLine("Name is:" + Name);
            Console.WriteLine("CSharp Programming");
        }
        public void CourseDescription()
        {
            Console.WriteLine("CSharp Programming in .Core Environment");
        }
    }
    internal class Interface
    {
        public static void Main()
        {
            Institution institution = new Institution();
            institution.Name = "John";
            institution.Details();
            institution.CourseDescription();
        }
    }
}
