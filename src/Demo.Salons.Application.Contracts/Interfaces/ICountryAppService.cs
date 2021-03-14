using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Salons.Salons
{
    public interface ICountryAppService :
        ICrudAppService< //Defines CRUD methods
            CountryDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateCountryDto> //Used to create/update a entity
    {
    }
}
