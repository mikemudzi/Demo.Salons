using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Salons.Salons
{
    public class Service : FullAuditedAggregateRoot<long>
    {
        public string ServiceName { get; set; }
        public string ServiceCode { get; set; }
        public decimal? ServiceCost { get; set; }
        public int? ServiceMinutes { get; set; }

    }
}
