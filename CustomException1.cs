using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NIIT
{
    internal class ValidateNameException:Exception
    {
        public ValidateNameException(string message):base(String.Format("Invalid Student Name:{0}",message))
        {

        }
    }
    public class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Admin2
    {
        public static void Main()
        {
            Employee1 employee = null;
            try
            {
                employee = new Employee1();
                employee.Name = "John1";
                NameValidation(employee);
                Console.WriteLine("Valid Student name: {0}",employee.Name);
            }
            catch (ValidateNameException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        public static void NameValidation(Employee1 emp)
        {
            Regex regex = new Regex("^[A-Z][a-z]+$");
            if(!regex.IsMatch(emp.Name))
                throw new ValidateNameException(emp.Name);
        }
    }
}
