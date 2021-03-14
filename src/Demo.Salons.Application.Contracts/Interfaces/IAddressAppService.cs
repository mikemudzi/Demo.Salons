using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Salons.Salons
{
    public interface IAddressAppService :
        ICrudAppService< //Defines CRUD methods
            AddressDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateAddressDto> //Used to create/update a entity
    {
    }
}
