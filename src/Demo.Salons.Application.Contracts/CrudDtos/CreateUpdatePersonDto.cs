using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Salons.Salons
{
    public class CreateUpdatePersonDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TitleId { get; set; }
        public string MobileNumber { get; set; }
        public string HomeNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
