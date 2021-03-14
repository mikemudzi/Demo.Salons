using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Salons.Salons
{
    public interface ILookupValueAppService :
        ICrudAppService< //Defines CRUD methods
            LookupValueDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateLookupValueDto> //Used to create/update a entity
    {
        Task<List<LookupValueDto>> GetLookupValuesByType(string type);
    }
}
