using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var Employee = int.Parse(Console.ReadLine());
            var Salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Employee ID: {0:D8}", Employee);
            Console.WriteLine("Salary: {0:F2}", Salary);



        }
    }
}
