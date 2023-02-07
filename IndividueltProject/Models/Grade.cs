using System;
using System.Collections.Generic;

namespace IndividueltProject.Models;

public partial class Grade
{
    public int GradeId { get; set; }

    public int CourseId { get; set; }

    public int TeacherId { get; set; }

    public int StudentId { get; set; }

    public int Grade1 { get; set; }

    public DateTime GradeDate { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Employee Teacher { get; set; } = null!;
}
