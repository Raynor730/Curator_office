using System;
using System.Collections.Generic;

namespace сurator_office.Models;

public partial class CurrentStatement
{
    public int Id { get; set; }

    public int IdDisciplinesTeachers { get; set; }

    public DateOnly Date { get; set; }

    public virtual ICollection<CurrentStatementsStudent> CurrentStatementsStudents { get; set; } = new List<CurrentStatementsStudent>();

    public virtual DisciplinesTeacher IdDisciplinesTeachersNavigation { get; set; } = null!;
}
