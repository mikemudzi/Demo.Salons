using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Salons.Salons
{
    public class CreateUpdateCountryDto
    {
        public string CountryName { get; set; }

        public string TwoLetterIsoCode { get; set; }

        public string ThreeLetterIsoCode { get; set; }

        public int? NumericIsoCode { get; set; }
    }
}
