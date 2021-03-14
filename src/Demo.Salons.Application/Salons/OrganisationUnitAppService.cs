using System;
using Demo.Salons.Salons;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo.Salons.Salons
{
    public class OrganisationUnitAppService :
        CrudAppService<
            OrganisationUnit, //The entity
            OrganisationUnitDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateOrganisationUnitDto>, //Used to create/update a entity
        IOrganisationUnitAppService //implement the I<Entity>AppService
    {
        public OrganisationUnitAppService(IRepository<OrganisationUnit, long> repository)
           : base(repository)
        {

        }
    }
}
