using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Salons.Salons
{
    public class Product : FullAuditedAggregateRoot<long>
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
    }
}
