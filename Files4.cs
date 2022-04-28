using System;
using System.IO;
using System.Linq;
//Serialization
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    //Serializable is class->Attribute
    //sealed-to restrict other classes from inheriting a class
    [Serializable]
    class Files
    {
        //Variables
        public int ID;
        public String Name;
        public String Designation;
        public int Age;
        static void Main(string[] args)
        {
            Files obj = new Files();
            obj.ID = 1;
            obj.Name = "John";
            obj.Designation = "HR";
            obj.Age = 25;

            //Encryption and Decryption
            //IFormatter->Interface(Serialize and Deserialize),BinaryFormatter(class)->inheriting->IFormatter
           
            //Base->Derived
            IFormatter formatter = new BinaryFormatter();

            //Stream->abstract class,Filestream(class)-inheriting the stream class
            //Base->Derived
            Stream stream = new FileStream(@"E:\ExampleNew.txt", FileMode.Create, FileAccess.Write);

            //stream->ExampleNew.txt  obj->ID and Name
            formatter.Serialize(stream, obj);
            stream.Close();

            //Base->Derived
            stream = new FileStream(@"E:\ExampleNew.txt", FileMode.Open, FileAccess.Read);

            //Files-user-defined class
            //(Files)->typecasting the content into class object
            Files objnew = (Files)formatter.Deserialize(stream);

            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.Name);
            Console.WriteLine(objnew.Designation);
            Console.WriteLine(objnew.Age);

            Console.ReadKey();
        }
    }
}