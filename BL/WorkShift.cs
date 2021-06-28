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
            => (_employee, _startTime, _endTime)
            = (employee, startTime, endTime);

        public double getShiftPaycheck()
        {
            return getShiftLength() * employee.position.getHourlyRate();
        }
        public double getShiftLength()
        {
            // TODO: Check if what total hours stands for -> if it rounds or not
            return (endTime - startTime).TotalHours;
        }

    }
}
