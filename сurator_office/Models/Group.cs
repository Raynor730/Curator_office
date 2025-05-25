using System;
using System.Collections.Generic;

namespace сurator_office.Models;

public partial class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string SpecializationKode { get; set; } = null!;

    public string SpecializationName { get; set; } = null!;

    public short YearOfAdmission { get; set; }

    public short YearOfGraduation { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
