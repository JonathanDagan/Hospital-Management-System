using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class WorkManager
    {
        public HashSet<WorkShift> staffHours { get; }
        public WorkManager(HashSet<WorkShift> staffHours = null)
        {
            this.staffHours = staffHours;
        }
        public double calcEmployeeSalary(IEmployee employee)
        {
            var employeesHours = staffHours.Where(shift => shift.employee.socialId == employee.socialId);
            double salary;

            if (employee.getEmployeesHighestRank() < ERank.decisionMaker)
            {
                salary = employeesHours.Sum(shift => shift.getShiftPaycheck());
            }
            else {
                var totalHours = employeesHours.Sum(shift => shift.getShiftLength());

                if (totalHours < 50 || totalHours < 200)
                {
                    salary = employeesHours.Sum(shift => shift.getShiftPaycheck());
                }
                else
                {
                    /*
                    There should be a bug here where if an employee switches position in the end of the month
                    to a managment position he would get a payrate for the entire month
                    */
                    salary = employee.position.getHourlyRate() * 200;
                }
            }

            return salary;
        }
        public double calcStaffSalary(HashSet<IEmployee> departments)
        {
            return departments.Sum(employee => calcEmployeeSalary(employee));
        }

    }
}
