using System;
using System.Globalization;

namespace BL
{
    public class WorkShift
    {
        public IEmployee employee { get; }
        public DateTime startTime { get; }
        public DateTime endTime { get; }
        public WorkShift(IEmployee employee, DateTime startTime, DateTime endTime)
        {
            this.employee = employee;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public double GetShiftPaycheck()
        {
            return GetShiftLength() * employee.position.GetHourlyRate();
        }
        public double GetShiftLength()
        {
            // TODO: Check if what total hours stands for -> if it rounds or not
            return (endTime - startTime).TotalHours;
        }

    }
}
