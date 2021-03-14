using System;
using Volo.Abp.Application.Dtos;

namespace Demo.Salons.Salons
{
    public class LookupTypeDto : FullAuditedEntityDto<long> 
    {
        public string type { get; set; }
    }
}
