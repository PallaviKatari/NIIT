using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIIT
{
    //Inheritance-Reusability
    //Types-Single,Multi-level,hybrid,Hierarchial
    //Multiple Inheritance-not supported-instead Interfaces concept is used
    internal class Employee
    {
        protected int eid;
        protected string ename;
        public void Display()
        {
            Console.WriteLine("Base Class");
        }
    }
    internal class Department:Employee
    {
        public int did;
        public string dname;
        
        public void GetEmpDetails()
        {
            eid = 1001;
            ename = "John";
            did = 100;
            dname = "CSharp";
            Console.WriteLine($"Employee {eid}'s name is {ename} and he is in department {did} {dname}");
        }
    }
    internal class Admin:Department
    {
        public void AdminClass()
        {
            Console.WriteLine("ADMIN");
        }
    }
    internal class Admin1:Department
    {
        public void Admin1Class()
        {
            Console.WriteLine("ADMIN1");
        }
    }
    public class Inheritance
    {
        public static void Main()
        {
            //Department department = new Department();
            //department.Display();
            //department.GetEmpDetails();
            Admin a=new Admin();
            a.AdminClass();
            a.Display(); 
            a.GetEmpDetails();   
        }
    }
}
