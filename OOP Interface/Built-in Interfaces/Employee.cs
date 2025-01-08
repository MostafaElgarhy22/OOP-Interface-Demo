using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface.Built_in_Interfaces
{
    internal class Employee : ICloneable, IComparable
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

        public int CompareTo(object? obj)
        {
            Employee? other = (Employee)obj; // Explicit Casting
                                             // unsafe casting [May Throw an Exception]

            return this.Salary.CompareTo(other?.Salary);

         //   return - this.Salary.CompareTo(other?.Salary);  // Disc


            //if(other is null) 
            //    return 1;

            //if (this.Salary > other.Salary) 
            //    return 1;   
            //else if(this.Salary < other.Salary)
            //    return -1;
            //    return 0;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }


    }
}
