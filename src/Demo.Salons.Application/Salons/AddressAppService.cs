using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo.Salons.Salons
{
    public class AddressAppService :
        CrudAppService<
            Address, //The entity
            AddressDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateAddressDto>, //Used to create/update a entity
        IAddressAppService //implement the I<Entity>AppService
    {
        public AddressAppService(IRepository<Address, long> repository)
          : base(repository)
        {

        }
    }
}
