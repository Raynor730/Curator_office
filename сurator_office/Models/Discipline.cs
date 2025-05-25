using System;
using System.Collections.Generic;

namespace сurator_office.Models;

public partial class Discipline
{
    public int Id { get; set; }

    public string Kode { get; set; } = null!;

    public string DisciplineName { get; set; } = null!;

    public virtual ICollection<DisciplinesTeacher> DisciplinesTeachers { get; set; } = new List<DisciplinesTeacher>();
}
