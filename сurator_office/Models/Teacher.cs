using System;
using System.Collections.Generic;

namespace сurator_office.Models;

public partial class Teacher
{
    public int Id { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public virtual ICollection<DisciplinesTeacher> DisciplinesTeachers { get; set; } = new List<DisciplinesTeacher>();
}
