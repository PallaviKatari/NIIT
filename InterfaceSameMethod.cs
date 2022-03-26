// C# program to illustrate the concept 
// of how to inherit multiple interfaces 
// with the same method name
using System;

// Interface I1 and I2 
// contains same method
interface I1
{

    // method declaration
    void mymethod();
}

interface I2
{

    // method declaration
    void mymethod();
}

// Geeks implements both 
// G1 and G2 interface
class InterfaceMethod : I1, I2
{
    // Here mymethod belongs to 
    // I1 interface
    void I1.mymethod()
    {
        Console.WriteLine("INTERFACE ONE");
    }

    // Here mymethod belongs to 
    // I2 interface
    void I2.mymethod()
    {
        Console.WriteLine("INTERFACE TWO");
    }
}

// Driver Class
public class MainClass
{

    // Main Method
    static public void Main()
    {

        // Creating object of InterfaceMethod
        // of I1 interface
        I1 obj = new InterfaceMethod();

        // calling I1 interface method
        obj.mymethod();

        // Creating object of InterfaceMethod
        // of I2 interface
        I2 ob = new InterfaceMethod();

        // calling I2 interface method
        ob.mymethod();
    }
}