using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo.Salons.Salons
{
    public class ClientAppService :
        CrudAppService<
            Client, //The entity
            ClientDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateClientDto>, //Used to create/update a entity
        IClientAppService //implement the I<Entity>AppService
    {
        public ClientAppService(IRepository<Client, long> repository)
          : base(repository)
        {

        }
    }
}
