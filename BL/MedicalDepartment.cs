using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class MedicalDepartment: IDepartment
    {
        public HashSet<MedicalEmployee> staff { get; set; }
    }
}
