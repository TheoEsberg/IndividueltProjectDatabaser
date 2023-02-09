using IndividueltProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IndividueltProject.Controls
{
    internal class Teachers
    {
        public static void ShowAllTeahers()
        {
            var context = new IndividualProjectDbContext();
            var teachers = (from c in context.Courses join e in context.Employees on c.TeacherId equals e.EmployeeId select new
            {
                EmployeeID = e.EmployeeId,
                EmployeeName = e.FullName,
                EmployeeTitle = e.WorkTitle,
                CourseName = c.CourseName
            }).ToList();

            foreach (var teacher in teachers.OrderBy(c => c.EmployeeTitle))
            {
                Console.WriteLine(teacher.CourseName + ", " + teacher.EmployeeName + ", " + teacher.EmployeeTitle);
            }
        }
    }
}
