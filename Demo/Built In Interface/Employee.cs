using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Built_In_Interface
{
    internal class Employee02 : ICloneable, IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary {  get; set; }

        public Employee02() { }
        // Copy Constructor
        public Employee02(Employee02 e)
        {
            this.Id = e.Id;
            this.Name = e.Name;
            this.Salary = e.Salary;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary}";
        }
        public object Clone()
        {
            return new Employee02(this);
            //return new Employee() { Id = this.Id, Name = this.Name, Salary = this.Salary };
        }

        public int CompareTo(object? obj)
        {
            Employee02? e = (Employee02?)obj;
            if(this.Salary > e?.Salary)
                return 1;
            else if(this.Salary < e?.Salary)
                return -1;
            return 0;
        }
    }
}
