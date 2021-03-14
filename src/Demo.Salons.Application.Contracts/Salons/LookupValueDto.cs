using System;
using Volo.Abp.Application.Dtos;

namespace Demo.Salons.Salons
{
    public class LookupValueDto : FullAuditedEntityDto<long>
    {
        public long LookupTypeId { get; set; }
        public string Description { get; set; }
        public string ValueCode { get; set; }
        public string ValueName { get; set; }
    }
}
