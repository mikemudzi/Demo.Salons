using System;
using Volo.Abp.Application.Dtos;

namespace Demo.Salons.Salons
{
    public class AddressDto : FullAuditedEntityDto<long>
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
