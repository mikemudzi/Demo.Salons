using System;
using Volo.Abp.Application.Dtos;

namespace Demo.Salons.Salons
{
    public class ProductDto : FullAuditedEntityDto<long>
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
    }
}
