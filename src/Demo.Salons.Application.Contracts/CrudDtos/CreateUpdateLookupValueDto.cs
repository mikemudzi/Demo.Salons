using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Salons.Salons
{
    public class CreateUpdateLookupValueDto
    {
        public long LookupTypeId { get; set; }
        public string Description { get; set; }
        public string ValueCode { get; set; }
        public string ValueName { get; set; }
    }
}
