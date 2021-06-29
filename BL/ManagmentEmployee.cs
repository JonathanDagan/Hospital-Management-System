using System;

namespace BL
{
    public class ManagmentEmployee: IEmployee
    {
        public Id socialId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Job position { get; set; }
        public ManagmentEmployee(Id socialId, string firstName, string lastName, Job position)
        {
            this.socialId = socialId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }

        public double calcMonthsSalary()
        {
            // Todo: implement
            return 0;
        }
    }
}
