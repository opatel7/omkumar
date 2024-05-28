using System;
using System.Globalization;
namespace ConsoleApp5
{ 
    class Car
    {
        public string Name = "Mustang";
    }
    class Program
    {
        // Data Members
        // member functions

        string myvariable = "nothing"; 
        static void Main(string[] args) // private by default
        {
              // object creation 
            Class1 obj1 = new Class1();
            Class1 obj2 = new Class1();
            
            obj1.Displaydata();
            obj2.Displaydata();

            Console.ReadLine();

            Car object1 = new Car();
            Console.WriteLine(object1.Name);
            Console.ReadLine();
        }
    }
}
