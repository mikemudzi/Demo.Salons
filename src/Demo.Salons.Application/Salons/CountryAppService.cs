using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo.Salons.Salons
{
    public class CountryAppService :
        CrudAppService<
            Country, //The entity
            CountryDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateCountryDto>, //Used to create/update a entity
        ICountryAppService //implement the I<Entity>AppService
    {
        public CountryAppService(IRepository<Country, long> repository)
          : base(repository)
        {

        }
    }
}
