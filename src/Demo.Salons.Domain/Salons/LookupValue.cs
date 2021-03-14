using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Salons.Salons
{
    public class LookupValue : FullAuditedAggregateRoot<long>
    {
        public long LookupTypeId { get; set; }
        public string Description { get; set; }
        public string ValueCode { get; set; }
        public string ValueName { get; set; }
    }
}
