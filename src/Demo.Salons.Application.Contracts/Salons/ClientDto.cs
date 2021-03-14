using System;
using Volo.Abp.Application.Dtos;

namespace Demo.Salons.Salons
{
    public class ClientDto : FullAuditedEntityDto<long>
    {
        public long? TitleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Code { get; set; }
        public long CategoryId { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string HomeNumber { get; set; }
        public string BusinessNumber { get; set; }
        public string BusinessName { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
    }
}
