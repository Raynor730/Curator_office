using System;
using System.Collections.Generic;

namespace сurator_office.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Patronymic { get; set; }

    public DateOnly Birthday { get; set; }

    public string? Email { get; set; }

    public string ActualAddress { get; set; } = null!;

    public int IdGroup { get; set; }

    public short Subgroup { get; set; }

    public short IdRole { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public bool? FullAge { get; set; }
    
    public bool? Excluded { get; set; }

    public virtual ICollection<CurrentStatementsStudent> CurrentStatementsStudents { get; set; } = new List<CurrentStatementsStudent>();

    public virtual Group IdGroupNavigation { get; set; } = null!;

    public virtual RolesInGroup IdRoleNavigation { get; set; } = null!;

    public virtual ICollection<IntermediateAttestationStudetn> IntermediateAttestationStudetns { get; set; } = new List<IntermediateAttestationStudetn>();
}
