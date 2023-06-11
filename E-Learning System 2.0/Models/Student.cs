using System;
using System.Collections.Generic;

namespace E_Learning_System_2._0.Models;

public partial class Student
{
    public int RegistrationNumber { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Username { get; set; } = null!;

    public virtual User UsernameNavigation { get; set; } = null!;
}
