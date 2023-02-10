using IndividueltProject.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IndividueltProject.Views
{
    internal class Menus
    {
        public static void StartMenu()
        {
            Console.Clear();
            Console.WriteLine("------------------------- MENU -------------------------");
            Console.WriteLine("\t1. Show all employees in each department");
            Console.WriteLine("\t2. Show all students");
            Console.WriteLine("\t3. Show all active courses");
            Console.WriteLine("\t4. Exit");


            var choise = Console.ReadLine();
            switch (choise) 
            {
                case "1":
                    Console.Clear();
                    Teachers.ShowAllTeahers();
                    break;
                case "2":
                    Console.Clear();
                    Students.ShowAllStudents();
                    break;
                case "3":
                    Console.Clear();
                    GetCourses.GetActiveCourses();
                    break;
                case "4":
                    break;
                default:
                    StartMenu();
                    break;
            }
        }
    }
}
