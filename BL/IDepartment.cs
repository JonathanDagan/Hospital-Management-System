using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public interface IDepartment
    {
        public string title { get; set; }
        public HashSet<IEmployee> staff { get; set; }
        // public IDepartment(string title, HashSet<IEmployee> staff)
        // {
        //     this.title = title;
        //     this.staff = staff;
        // }

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
