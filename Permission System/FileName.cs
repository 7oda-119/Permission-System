using System;
using System.Collections.Generic;
using System.Text;

namespace Permission_System
{
    [Flags]
    internal enum Permission
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
}
