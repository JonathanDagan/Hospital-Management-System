using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class WorkManager
    {
        public HashSet<WorkShift> staffHours { get; }
        public static double calcEmployeeSalary(IEmployee employee)
        {
            var employeesHours = staffHours.Where(shift => shift.employee.socialId == employee.socialId);
            employeesHours.Sum(shift => shift.getShiftPaycheck());
        }
        public static double calcStaffSalary(HashSet<IEmployee> employee)
        {
            return departments.Sum(employee => calcEmployeeSalary(employee));
        }

    }
}
