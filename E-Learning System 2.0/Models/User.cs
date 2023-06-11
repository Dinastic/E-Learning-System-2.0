using System;
using System.Collections.Generic;

namespace E_Learning_System_2._0.Models;

public partial class User
{
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    public virtual ICollection<GradeChapterUser> GradeChapterUsers { get; set; } = new List<GradeChapterUser>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
