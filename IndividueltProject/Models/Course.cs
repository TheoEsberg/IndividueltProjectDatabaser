using System;
using System.Collections.Generic;

namespace IndividueltProject.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public int TeacherId { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Connection> Connections { get; } = new List<Connection>();

    public virtual ICollection<Grade> Grades { get; } = new List<Grade>();

    public virtual Employee Teacher { get; set; } = null!;
}
