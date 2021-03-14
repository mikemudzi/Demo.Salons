using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Salons.Salons
{
    public class LookupType : FullAuditedAggregateRoot<long>
    {
        public string type { get; set; }
    }
}
