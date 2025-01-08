using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface.Built_in_Interfaces
{
    internal class Employee : ICloneable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }

        public object Clone()
        {
            return new Employee
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary,
            };
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }
    }
}
