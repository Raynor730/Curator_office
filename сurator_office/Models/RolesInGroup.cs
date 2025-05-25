using System;
using System.Collections.Generic;

namespace сurator_office.Models;

public partial class RolesInGroup
{
    public short Id { get; set; }

    public string Role { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
