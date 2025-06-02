using System;
using System.Collections.Generic;

namespace сurator_office.Models;

public partial class IntermediateAttestationStudent
{
    public int Id { get; set; }

    public int IdStudent { get; set; }

    public DateOnly DateOfRetake { get; set; }

    public short Estimation { get; set; }

    public int IdInterimStatements { get; set; }

    public virtual Student IdStudentNavigation { get; set; } = null!;
}
