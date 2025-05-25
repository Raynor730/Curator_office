using System;
using System.Collections.Generic;

namespace сurator_office.Models;

public partial class TypesIntermediateAttestation
{
    public short Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<InterimStatement> InterimStatements { get; set; } = new List<InterimStatement>();
}
