using System;
using Volo.Abp.Application.Dtos;

namespace Demo.Salons.Salons
{
    public class CountryDto : FullAuditedEntityDto<long>
    {
        public string CountryName { get; set; }

        public string TwoLetterIsoCode { get; set; }

        public string ThreeLetterIsoCode { get; set; }

        public int? NumericIsoCode { get; set; }
    }
}
