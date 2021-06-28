using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class ManagmentDepartment: IDepartment
    {
        public HashSet<ManagmentEmployee> staff { get; set; }
    }
}
