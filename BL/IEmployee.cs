using System;

namespace BL
{
    public interface IEmployee
    {
        public Id socialId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Job position { get; set; }
        // public IEmployee()
        // {

        // }

        public double calcMonthsSalary()
        {
            // Todo: implement
            return 0;
        }
        public ERank getEmployeesHighestRank()
        {
            // Todo: implement
            return 0;
        }
    }
}
