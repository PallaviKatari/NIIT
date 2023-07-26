using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    /// <summary>
    /// Using Objects as Parameters in C#
    /// </summary>
    public class myMethodParams
    {
        public int age { get; set; }
        public string name { get; set; }

        public myMethodParams()
        {
            age = 20;
            name = "John";
        }

        public void myFunction(myMethodParams theParams)
        {
            age = theParams.age;
            name = theParams.name;
            Console.WriteLine($"{name}'s age is {age}");
        }

        static void Main(string[] args)
        {
            myMethodParams theParams = new myMethodParams();
            theParams.myFunction(theParams);
        }
    }


}
