namespace Beetee.Task.Repository.Models
{
    public class HumanResource : AbstractEntity
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int Salary { get; set; }
        public string SocialSecurityNumber { get; set; }
    }
}
