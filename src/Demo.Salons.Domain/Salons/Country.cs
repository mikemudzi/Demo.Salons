using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Demo.Salons.Salons
{
    public class Country : FullAuditedAggregateRoot<long>
    {       
        public string CountryName { get; set; }

        public string TwoLetterIsoCode  { get; set; }

        public string ThreeLetterIsoCode  { get; set; }

        public int? NumericIsoCode { get; set; }
    }
}
