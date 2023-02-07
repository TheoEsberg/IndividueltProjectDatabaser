using System;
using System.Collections.Generic;

namespace IndividueltProject.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string SocialSecurityNumber { get; set; } = null!;

    public string FName { get; set; } = null!;

    public string LName { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public virtual ICollection<Connection> Connections { get; } = new List<Connection>();

    public virtual ICollection<Grade> Grades { get; } = new List<Grade>();
}
