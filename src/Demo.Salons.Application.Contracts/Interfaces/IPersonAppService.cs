using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Salons.Salons
{
    public interface IPersonAppService :
        ICrudAppService< //Defines CRUD methods
            PersonDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdatePersonDto> //Used to create/update a entity
    {
    }
}
