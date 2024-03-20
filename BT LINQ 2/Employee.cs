using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LINQ_2
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>() {
                new Employee {ID = 1, Name = "A", Age = 20, DepartmentID = 1, PositionID = 5},
                new Employee {ID = 2, Name = "D", Age = 21, DepartmentID = 2, PositionID = 4},
                new Employee {ID = 3, Name = "C", Age = 20, DepartmentID = 3, PositionID = 3},
                new Employee {ID = 4, Name = "B", Age = 22, DepartmentID = 4, PositionID = 2},
                new Employee {ID = 5, Name = "E", Age = 23, DepartmentID = 5, PositionID = 1},
            };
        }
    }
}
