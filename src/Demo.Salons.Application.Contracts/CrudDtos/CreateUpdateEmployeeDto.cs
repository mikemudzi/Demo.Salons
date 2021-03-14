using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Salons.Salons
{
    public class CreateUpdateEmployeeDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long? TitleId { get; set; }
        public string MobileNumber { get; set; }
        public string HomeNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateHired { get; set; }
        public long? EmployeeStatusId { get; set; }
    }
}
