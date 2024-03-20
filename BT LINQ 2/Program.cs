using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LINQ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = Department.GetDepartments();
            List<Employee> employees = Employee.GetEmployees();
            List<Position> positions = Position.GetPositions();
            while (true)
            {
                Console.WriteLine("nhap tu khoa tim kiem");
                string keyword = Console.ReadLine();

                Console.WriteLine("nhap tuoi tu");
                int minAge = int.Parse(Console.ReadLine());

                Console.WriteLine("nhap đen tuoi");
                int maxAge = int.Parse(Console.ReadLine());

                Console.WriteLine("Vi tri:");
                string positionKeyword = Console.ReadLine();

                Console.WriteLine("Phòng ban:");
                string departmentKeyword = Console.ReadLine();

                var searchResults = from emp in employees
                                    join dep in departments on emp.DepartmentID equals dep.DepartmentID
                                    join pos in positions on emp.PositionID equals pos.PositionID
                                    where (emp.Name.Contains(keyword) || dep.DepartmentName.Contains(keyword) || pos.PositionName.Contains(keyword))
                                        && emp.Age >= minAge && emp.Age <= maxAge
                                        && (positionKeyword == "" || pos.PositionName.Contains(positionKeyword))
                                        && (departmentKeyword == "" || dep.DepartmentName.Contains(departmentKeyword))
                                    select new
                                    {
                                        EmployeeName = emp.Name,
                                        EmployeeAge = emp.Age,
                                        Position = pos.PositionName,
                                        Department = dep.DepartmentName
                                    };

                Console.WriteLine("\nKet qua tim kiem:");
                if (!searchResults.Any())
                {
                    Console.WriteLine("khong tim thay nhan vien");
                }
                else
                {
                    foreach (var result in searchResults)
                    {
                        Console.WriteLine($"Tên nhân viên: {result.EmployeeName}, Tuổi: {result.EmployeeAge}, Vị trí: {result.Position}, Phòng ban: {result.Department}");
                    }
                }
            }
        }
    }
}
