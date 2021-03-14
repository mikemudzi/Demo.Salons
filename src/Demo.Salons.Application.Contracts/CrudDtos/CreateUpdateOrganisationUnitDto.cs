using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Salons.Salons
{
    public class CreateUpdateOrganisationUnitDto
    {
        public long? ParentId { get; set; }
        public string OrganisationName { get; set; }
        public string ContactNumber { get; set; }
        public string MainContactName { get; set; }
        public string MainContactEmailAddress { get; set; }
        public long? UnitStatusId { get; set; }
        public long? PhysicalAddressId { get; set; }
        public long? PostalAddressId { get; set; }
    }
}
