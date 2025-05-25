using System;
using System.Collections.Generic;

namespace сurator_office.Models;

public partial class DisciplinesTeacher
{
    public int Id { get; set; }

    public int IdDiscipline { get; set; }

    public int IdTeacher { get; set; }

    public short? Subgroup { get; set; }

    public virtual ICollection<CurrentStatement> CurrentStatements { get; set; } = new List<CurrentStatement>();

    public virtual Discipline IdDisciplineNavigation { get; set; } = null!;

    public virtual Teacher IdTeacherNavigation { get; set; } = null!;

    public virtual ICollection<InterimStatement> InterimStatements { get; set; } = new List<InterimStatement>();
}
