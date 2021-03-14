using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Salons.Salons
{
    public interface IOrganisationUnitAppService :
        ICrudAppService< //Defines CRUD methods
            OrganisationUnitDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateOrganisationUnitDto> //Used to create/update a entity
    {
    }
}
