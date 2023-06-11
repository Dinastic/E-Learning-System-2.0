using System;
using System.Collections.Generic;

namespace E_Learning_System_2._0.Models;

public partial class Chapter
{
    public int IdChapter { get; set; }

    public string Title { get; set; } = null!;

    public int Speciality { get; set; }

    public virtual ICollection<GradeChapterUser> GradeChapterUsers { get; set; } = new List<GradeChapterUser>();

    public virtual Speciality SpecialityNavigation { get; set; } = null!;
}
