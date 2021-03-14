using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Salons.Salons
{
    public class BookingService : FullAuditedAggregateRoot<long>
    {
        public long BookingId { get; set; }
        public long ServiceId { get; set; }
        public long EmployeeId { get; set; }
    }
}
