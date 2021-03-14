using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Salons.Salons
{
    public interface ISupplierAppService :
        ICrudAppService< //Defines CRUD methods
            SupplierDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateSupplierDto> //Used to create/update a entity
    {
    }
}
