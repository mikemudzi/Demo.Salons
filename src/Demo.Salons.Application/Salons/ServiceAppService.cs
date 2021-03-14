using System;
using Demo.Salons.Salons;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo.Salons.Salons
{
    public class ServiceAppService :
        CrudAppService<
            Service, //The entity
            ServiceDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateServiceDto>, //Used to create/update a entity
        IServiceAppService //implement the I<Entity>AppService
    {
        public ServiceAppService(IRepository<Service, long> repository)
           : base(repository)
        {

        }
    }
}
