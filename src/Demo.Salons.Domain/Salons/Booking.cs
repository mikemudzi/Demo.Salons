using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Salons.Salons
{
    public class Booking : FullAuditedAggregateRoot<long>
    {
        public DateTime BookingDateAndTime { get; set; }
        public long EmployeeId { get; set; }
        public long ClientId { get; set; }
        public long ServiceId { get; set; }
    }
}
