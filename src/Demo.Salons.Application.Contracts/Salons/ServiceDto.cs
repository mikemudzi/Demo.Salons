using System;
using Volo.Abp.Application.Dtos;

namespace Demo.Salons.Salons
{
    public class ServiceDto : FullAuditedEntityDto<long>
    {
        public string ServiceName { get; set; }
        public string ServiceCode { get; set; }
        public decimal? ServiceCost { get; set; }
        public int? ServiceMinutes { get; set; }
    }
}
