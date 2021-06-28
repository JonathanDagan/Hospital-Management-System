using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class Hospital
    {
        public string title { get; set; }
        public HashSet<Department> departments { get; set; }
        public Hospital(string title, HashSet<Department> departments) => (_title, _departments) = (title, departments);

        public double calcStaffSalary()
        {
            return departments.Sum(department => department.calcStaffSalary());
        }
        public void createDepartment(Department department)
        {
            departments.Add(department);
        }
        public void dismantleDepartment(Department department)
        {
            departments.Remove(department);
        }
    }
}
