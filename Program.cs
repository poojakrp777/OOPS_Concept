using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concept
{
    

    public class Program
    {
        static void Main(string[] args)
        {
            Developer d1 = new Developer(5000);
            Driver d2 = new Driver(3000);

            int a, b;

            a = d1.GetSalary();
            b = d2.GetSalary();
            Console.WriteLine($"Salary of developer : {a}");
            Console.WriteLine($"Salary of driver : {b}");
            Console.ReadLine();
        }
    }
}
