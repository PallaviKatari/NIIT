//Generics allow you to define the specification of the data type of

//programming elements in a class or a method,

//until it is actually used in the program. 

//In other words, generics allow you to write a class or method that can work with any data type.

//You write the specifications for the class or the method, with substitute parameters for data types. 

//When the compiler encounters a constructor for the class or a function call for the method,

//it generates code to handle the specific data type. 

//using System;
//namespace CSharpProgram
//{
//    //<GenericType>
//    //classname->GenericClass<DataType>
//    class GenericClass<T> // 1st call-string
//    {
//        public GenericClass(T msg) //1st call-string
//        {
//            Console.WriteLine(msg); //1st call-This ia a generic class
//        }
//        public void Show(T msg) //1st call-This is a generic method
//        {
//            Console.WriteLine(msg);
//        }
//    }
//    class ProgramGeneric
//    {
//        static void Main(string[] args)
//        {
//            //Passing string datatype
//            GenericClass<string> gen = new GenericClass<string>("This is generic class");
//            GenericClass<int> genI = new GenericClass<int>(101);
//            GenericClass<char> getCh = new GenericClass<char>('I');
//            gen.Show("This is generic method");
//            genI.Show(101);
//            getCh.Show('I');
//        }
//    }
//}
//----------------------------------------------------------------------------
//using System;
//namespace GenericsDemo
//{
//    public class ClsMain
//    {
//        private static void Main()
//        {
//            bool IsEqual = ClsCalculator.AreEqual(10, "xyz");//false
//            bool IsEqual1 = ClsCalculator.AreEqual("ABC", "ABC");//TRUE
//            if (IsEqual)
//            {
//                Console.WriteLine("Both are Equal");
//            }
//            else
//            {
//                Console.WriteLine("Both are Not Equal");
//            }
//            if (IsEqual1)
//            {
//                Console.WriteLine("Both are Equal");
//            }
//            else
//            {
//                Console.WriteLine("Both are Not Equal");
//            }
//            Console.ReadKey();
//        }
//    }
//    public class ClsCalculator
//    {
//        //Now this method can accept any data type
//        public static bool AreEqual(object value1, object value2)//object reference 10 and 20
//        {
//            return value1 == value2; //10==20 ABC==ABC
//        }
//    }}

//object-reference type
//int-value type
//value to reference - BOXING
//ref to value- Unboxing

//Let’s see the problem of the above code implementation.
//We get poor Performance due to boxing and unboxing. The object type needs to be converted to the value type.
//Now, the AreEuqal() method is not type - safe.Now it is possible to pass a string value for the first parameter and an integer value for the second parameter. 

//namespace GenericsDemo
//{
//    public class ClsMain
//    {
//        private static void Main()
//        {
//            bool IsEqual1 = ClsCalculator.AreEqual(10, 20);
//            bool IsEqual2 = ClsCalculator.AreEqual("ABC", "ABC");
//            bool IsEqual3 = ClsCalculator.AreEqual(10.5, 20.5);
//            if (IsEqual1)
//            {
//                Console.WriteLine("Both are Equal");
//            }
//            else
//            {
//                Console.WriteLine("Both are Not Equal");
//            }
//            if (IsEqual2)
//            {
//                Console.WriteLine("Both are Equal");
//            }
//            else
//            {
//                Console.WriteLine("Both are Not Equal");
//            }
//            if (IsEqual3)
//            {
//                Console.WriteLine("Both are Equal");
//            }
//            else
//            {
//                Console.WriteLine("Both are Not Equal");
//            }
//            Console.ReadKey();
//        }
//    }
//    public class ClsCalculator //Method Overloading
//    {
//        public static bool AreEqual(int value1, int value2)
//        {
//            return value1 == value2;
//        }
//        public static bool AreEqual(string value1, string value2)
//        {
//            return value1 == value2;
//        }
//        public static bool AreEqual(double value1, double value2)
//        {
//            return value1 == value2;
//        }
//    }
//}
//The problem with the above code implementation is that we are repeating the same logic in each and every method.
//However, if tomorrow we need to compare two float or two long values then again we need to create two more methods.


//We can solve all the above problems with Generics in C#.
//With generics, we will make the AreEqual() method to works with different types of data types.
//namespace GenericsDemo
//{
//    public class ClsMain
//    {
//        private static void Main()
//        {
//            bool IsEqual = ClsCalculator.AreEqual<int>(10, 20);
//            bool IsEqual = ClsCalculator.AreEqual<string>("ABC", "ABC");
//            bool IsEqual = ClsCalculator.AreEqual<double>(10, 20.5);
//            if (IsEqual)
//            {
//                Console.WriteLine("Both are Equal");
//            }
//            else
//            {
//                Console.WriteLine("Both are Not Equal");
//            }
//            Console.ReadKey();
//        }
//    }
//    public class ClsCalculator
//    {
//        public static bool AreEqual<T>(T value1, T value2)
//        {
//            return value1.Equals(value2);
//        }
//    }
//}
//------------------------------------------------------------
//using System;
//namespace GenericsDemo
//{
//    public class ClsMain
//    {
//        private static void Main()
//        {
//            bool IsEqual = ClsCalculator.AreEqual<string, int>("Hello", 10);
//            //bool IsEqual = ClsCalculator.AreEqual<string>("ABC", "ABC");
//            //bool IsEqual = ClsCalculator.AreEqual<double>(10, 20.5);
//            if (IsEqual)
//            {
//                Console.WriteLine("Both are Equal");
//            }
//            else
//            {
//                Console.WriteLine("Both are Not Equal");
//            }
//            Console.ReadKey();
//        }
//    }
//    public class ClsCalculator
//    {
//        public static bool AreEqual<T, T1>(T value1, T1 value2)
//        {
//            return value1.Equals(value2);
//        }
//    }
//}
//-----------------------------------------------------------------
using System;
namespace GenericsDemo
{
    //Let us create a generic class with a generic constructor, generic member variable, generic property,
    //and a generic method as shown below.

    //MyGenericClass is a Generic Class
    class MyGenericClass<T> //Generic type
    {
        //Generic variable
        //The data type is generic
        private T genericMemberVariable; //int
        
        //Generic Constructor
        //Constructor accepts one parameter of Generic type
        public MyGenericClass(T value) //int 10
        {
            genericMemberVariable = value;  //10
        }
        //Generic Method
        //Method accepts one Generic type Parameter
        //Method return type also Generic
        public T genericMethod(T genericParameter) //int 200
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);//int 200
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable); //int 10
            return genericMemberVariable; //10
        }
        //Generic Property
        //The data type is generic
        public T genericProperty { get; set; }
    }
    class Program
    {
        static void Main()
        {
            MyGenericClass<int> integerGenericClass = new MyGenericClass<int>(10);
            int val = integerGenericClass.genericMethod(200);//10
            Console.WriteLine(val); //10
            MyGenericClass<string> stringGenericClass = new MyGenericClass<string>("hello");
            string val1 = stringGenericClass.genericMethod("World");
            Console.WriteLine(val1);
            Console.ReadKey();
        }
    }
}