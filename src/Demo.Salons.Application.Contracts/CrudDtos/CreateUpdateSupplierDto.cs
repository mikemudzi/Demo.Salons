using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Salons.Salons
{
    public class CreateUpdateSupplierDto
    {
        public string SupplierName { get; set; }
        public string ContactNumber { get; set; }
        public string MainContactName { get; set; }
        public string MainContactEmailAddress { get; set; }
        public long SupplierStatusId { get; set; }
        public long? PhysicalAddressId { get; set; }
        public long? PostalAddressId { get; set; }
    }
}
