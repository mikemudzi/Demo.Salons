using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Salons.Salons
{
    public class CreateUpdateAddressDto 
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
