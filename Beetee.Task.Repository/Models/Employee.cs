using System;

namespace Beetee.Task.Repository.Models
{
    public enum Gender
    {
        Male, Female
    }

    public class Employee : AbstractEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public Gender Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
    }
}
