using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Salons.Salons
{
    public class CreateUpdateServiceDto
    {
        public string ServiceName { get; set; }
        public string ServiceCode { get; set; }
        public decimal? ServiceCost { get; set; }
        public int? ServiceMinutes { get; set; }
    }
}
