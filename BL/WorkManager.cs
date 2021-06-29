using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class WorkManager
    {
        public HashSet<WorkShift> staffHours { get; }
        public double calcEmployeeSalary(IEmployee employee)
        {
            var employeesHours = staffHours.Where(shift => shift.employee.socialId == employee.socialId);
            // curently returns all paychecks, not this months -> fix
            return employeesHours.Sum(shift => shift.getShiftPaycheck());
        }
        public double calcStaffSalary(HashSet<IEmployee> departments)
        {
            return departments.Sum(employee => calcEmployeeSalary(employee));
        }

    }
}
