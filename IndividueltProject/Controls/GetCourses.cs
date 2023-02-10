using IndividueltProject.Models;
using IndividueltProject.Views;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueltProject.Controls
{
    internal class GetCourses
    {
        public static void GetActiveCourses()
        {
            var context = new IndividualProjectDbContext();
            var courses = context.Courses;
            var isActive = " is not active";

            foreach (var course in courses)
            {
                isActive = (course.IsActive) ? " is active" : " is not active";
                Console.WriteLine(course.CourseName + "" + isActive);
            }

            Console.WriteLine("\nPress any key to return:");
            Console.ReadKey();
            Menus.StartMenu();
        }
    }
}
