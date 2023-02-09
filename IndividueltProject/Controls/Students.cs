using IndividueltProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueltProject.Controls
{
    internal class Students
    {
        public static void ShowAllStudents()
        {
            var context = new IndividualProjectDbContext();
            var students = context.Students;

            foreach (var student in students.OrderBy(c => c.ClassName))
            {
                Console.WriteLine($"{student.ClassName} : {student.FName} {student.LName}");
            }
        }
    }
}
