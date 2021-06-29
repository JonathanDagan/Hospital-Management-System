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

        public ERank getEmployeesHighestRank()
        {
            // Todo: implement
            return 0;
        }
    }
}
