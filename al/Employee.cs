using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEmployee
{
    internal class Employee
    {
       public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int salary { get; set; }

        public Employee() { }
        public Employee(int id, int age, string name, int salary)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
        }

        public override string ToString()
        {
            return "Employee : " + id + " " + name + " " + age + " " + salary;
        }
    }
}
