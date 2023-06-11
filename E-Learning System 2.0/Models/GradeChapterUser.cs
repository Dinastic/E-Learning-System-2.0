using System;
using System.Collections.Generic;

namespace E_Learning_System_2._0.Models;

public partial class GradeChapterUser
{
    public string UsernameUsers { get; set; } = null!;

    public int IdChapters { get; set; }

    public int? Grade { get; set; }

    public virtual Chapter IdChaptersNavigation { get; set; } = null!;

    public virtual User UsernameUsersNavigation { get; set; } = null!;
}
