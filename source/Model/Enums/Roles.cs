using System;

namespace HRMS.Model
{
    [Flags]
    public enum Roles
    {
        None = 0,
        User = 1,
        Admin = 2
    }
}
