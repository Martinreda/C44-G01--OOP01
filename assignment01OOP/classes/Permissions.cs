using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment01OOP.classes
{
    [Flags]
    internal enum Permissions : byte
    {
        excute = 1,
        read = 2,
        Write = 4,
        delete = 8
    }
}
