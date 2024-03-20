using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LINQ_2
{
    class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public static List<Department> GetDepartments()
        {
            return new List<Department>() {
                new Department {DepartmentID = 1, DepartmentName = "IT"},
                new Department {DepartmentID =  2, DepartmentName = "HR"},
                new Department {DepartmentID = 3 ,DepartmentName = "Maketing" },
                new Department {DepartmentID = 4 ,DepartmentName = "Sale" },
                new Department {DepartmentID = 5 ,DepartmentName = "Dev" },
            };
        }
    }
}
