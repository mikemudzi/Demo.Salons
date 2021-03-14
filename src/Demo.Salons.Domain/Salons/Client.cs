using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Salons.Salons
{
    public class Client : FullAuditedAggregateRoot<long>
    {
        public long? TitleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Code { get; set; }
        public long CategoryId { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string HomeNumber { get; set; }
        public string BusinessNumber { get; set; }
        public string BusinessName { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
    }
}
