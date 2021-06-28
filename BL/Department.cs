using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class Department
    {
        public string title { get; set; }
        public HashSet<IEmployee> staff { get; set; }
        public Department(string title, HashSet<IEmployee> staff) => (_title, _staff) = (title, staff);

        public void hireEmployee(IEmployee employee)
        {
            staff.Add(employee);
        }
        public void fireEmployee(IEmployee employee)
        {
            staff.Remove(employee);
        }
    }
}
