using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Salons.Salons
{
    public interface ILookupTypeAppService :
        ICrudAppService< //Defines CRUD methods
            LookupTypeDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateLookupTypeDto> //Used to create/update a entity
    {
    }
}
