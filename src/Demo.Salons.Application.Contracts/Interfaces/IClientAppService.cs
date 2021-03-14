using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Salons.Salons
{
    public interface IClientAppService :
        ICrudAppService< //Defines CRUD methods
            ClientDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateClientDto> //Used to create/update a entity
    {
    }
}
