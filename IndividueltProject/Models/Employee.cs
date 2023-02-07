using System;
using System.Collections.Generic;

namespace IndividueltProject.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string WorkTitle { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; } = new List<Course>();

    public virtual ICollection<Grade> Grades { get; } = new List<Grade>();
}
