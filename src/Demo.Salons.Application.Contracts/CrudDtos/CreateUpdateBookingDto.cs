using System;
using System.ComponentModel.DataAnnotations;


namespace Demo.Salons.Salons
{
    public class CreateUpdateBookingDto
    {
        public DateTime BookingDateAndTime { get; set; }
        public long EmployeeId { get; set; }
        public long ClientId { get; set; }
        public long ServiceId { get; set; }
    }
}
