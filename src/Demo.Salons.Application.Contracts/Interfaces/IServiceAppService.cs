using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Salons.Salons
{
    public interface IServiceAppService :
        ICrudAppService< //Defines CRUD methods
            ServiceDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateServiceDto> //Used to create/update a entity
    {
    }
}
