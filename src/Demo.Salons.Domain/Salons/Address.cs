using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Salons.Salons
{
    public class Address : FullAuditedAggregateRoot<long>
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Surburb { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public long? CountryId { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }

    }
}
