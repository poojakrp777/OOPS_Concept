using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concept
{
    abstract class Employee //abstract class
    {
        public abstract int GetSalary(); //abstract method
    }

    class Developer : Employee
    {
        private int salary;
        public Developer(int s)
        {
            salary = s;
        }
        public override int GetSalary()
        {
            return salary;
        }
    }

    class Driver : Employee
    {
        private int salary;
        public Driver(int s)
        {
            salary = s;
        }
        public override int GetSalary()
        {
            return salary;
        }
    }
}
