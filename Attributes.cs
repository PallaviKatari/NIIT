//Directive
#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NIIT
{
    /// <summary>
    /// Attributes-declarative information of metadata-class,method,property,types,assembly etc
    /// Pre-defined-AttributeUsage,Conditional,Obsolete
    /// User-defined - create our own attributes which inherits from the base class- Attribute
    /// </summary>
    internal class Attributes
    {
        [Obsolete("Use NewMethod, I am of no use anymore",true)]
        static void OldMethod()
        {
            Console.WriteLine("I am not in use anymore!!!");
        }
        static void NewMethod()
        {
            Console.WriteLine("I am the one who serves your requirement!!!");
        }

        public static void Main()
        {
            //OldMethod();
            NewMethod();
            Attributes1.Details("John");
        }
    }

    internal class Attributes1
    {
        [Conditional("DEBUG")]

        public static void Details(string name)
        {
            Console.WriteLine(name);
        }
    }
}
