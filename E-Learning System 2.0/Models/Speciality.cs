using System;
using System.Collections.Generic;

namespace E_Learning_System_2._0.Models;

public partial class Speciality
{
    public int IdSpeciality { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();
}
