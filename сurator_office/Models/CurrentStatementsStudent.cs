using System;
using System.Collections.Generic;

namespace сurator_office.Models;

public partial class CurrentStatementsStudent
{
    public int Id { get; set; }

    public int IdCurrentStatements { get; set; }

    public int IdStudent { get; set; }

    public short Estimation { get; set; }

    public virtual CurrentStatement IdCurrentStatementsNavigation { get; set; } = null!;

    public virtual Student IdStudentNavigation { get; set; } = null!;
}
