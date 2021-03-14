using System;
using Volo.Abp.Application.Dtos;


namespace Demo.Salons.Salons
{
    public class BookingDto: FullAuditedEntityDto<long>
    {
        public DateTime BookingDateAndTime { get; set; }
        public long EmployeeId { get; set; }
        public long ClientId { get; set; }
        public long ServiceId { get; set; }
    }
}
