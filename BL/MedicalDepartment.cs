using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class MedicalDepartment: IDepartment
    {
        public string title { get; set; }
        public HashSet<IEmployee> staff { get; set; }
        public MedicalDepartment(string title, HashSet<IEmployee> staff)
        {
            this.title = title;
            this.staff = staff;
        }

        public void HireEmployee(MedicalEmployee employee)
        {
            staff.Add(employee);
        }
        public void FireEmployee(MedicalEmployee employee)
        {
            staff.Remove(employee);
        }
    }
}
