using System;
using System.Collections.Generic;

namespace сurator_office.Models;

public partial class InterimStatement
{
    public int Id { get; set; }

    public int IdDisciplinesTeachers { get; set; }

    public DateOnly Date { get; set; }

    public short IdTypeIntermediateAttestation { get; set; }

    public virtual DisciplinesTeacher IdDisciplinesTeachersNavigation { get; set; } = null!;

    public virtual TypesIntermediateAttestation IdTypeIntermediateAttestationNavigation { get; set; } = null!;
}
