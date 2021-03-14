using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo.Salons.Salons
{
    public class LookupTypeAppService :
        CrudAppService<
            LookupType, //The entity
            LookupTypeDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateLookupTypeDto>, //Used to create/update a entity
        ILookupTypeAppService //implement the I<Entity>AppService
    {
        public LookupTypeAppService(IRepository<LookupType, long> repository)
          : base(repository)
        {

        }
    }
}
