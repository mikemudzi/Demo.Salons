using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Salons.Salons
{
    public class OrganisationUnit : FullAuditedAggregateRoot<long>
    {
        public long? ParentId { get; set; }
        public string OrganisationName { get; set; }
        public string ContactNumber { get; set; }
        public string MainContactName { get; set; }
        public string MainContactEmailAddress { get; set; }
        public long? UnitStatusId { get; set; }
        public long? PhysicalAddressId { get; set; }
        public long? PostalAddressId { get; set; }
    }
}
