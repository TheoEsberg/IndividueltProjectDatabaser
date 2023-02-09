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
            var employees = context.Employees;

            foreach (var employee in employees.GroupBy(x => x.WorkTitle))
            {
                Console.WriteLine($"Amount of {employee.Key} = {employee.Count()}");
                foreach (var emp in employee)
                {
                    if (emp.WorkTitle == employee.Key)
                    {
                        Console.WriteLine($"\t{emp.FullName}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
