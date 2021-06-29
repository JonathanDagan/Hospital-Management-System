using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class ManagmentDepartment: IDepartment
    {
        public string title { get; set; }
        public HashSet<IEmployee> staff { get; set; }
        public ManagmentDepartment(string title, HashSet<IEmployee> staff)
        {
            this.title = title;
            this.staff = staff;
        }

        public void HireEmployee(ManagmentEmployee employee)
        {
            staff.Add(employee);
        }
        public void FireEmployee(ManagmentEmployee employee)
        {
            staff.Remove(employee);
        }
    }
}
