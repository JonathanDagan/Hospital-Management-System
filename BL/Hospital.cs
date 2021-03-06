using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class Hospital
    {
        public string title { get; set; }
        public HashSet<IDepartment> departments { get; set; }
        public Hospital(string title, HashSet<IDepartment> departments)
        {
            this.title = title;
            this.departments = departments;
        }

        public void CreateDepartment(IDepartment department)
        {
            departments.Add(department);
        }
        public void DismantleDepartment(IDepartment department)
        {
            departments.Remove(department);
        }
    }
}
