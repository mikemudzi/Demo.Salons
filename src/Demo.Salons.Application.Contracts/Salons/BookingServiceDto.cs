using System;
using Volo.Abp.Application.Dtos;

namespace Demo.Salons.Salons
{
    public class BookingServiceDto : FullAuditedEntityDto<long>
    {
        public long BookingId { get; set; }
        public long ServiceId { get; set; }
        public long EmployeeId { get; set; }
    }
}
