using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Salons.Salons
{
    public class CreateUpdateBookingServiceDto
    {
        public long BookingId { get; set; }
        public long ServiceId { get; set; }
        public long EmployeeId { get; set; }
    }
}
