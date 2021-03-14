using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Salons.Salons
{
    public interface IProductAppService :
        ICrudAppService< //Defines CRUD methods
            ProductDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateProductDto> //Used to create/update a entity
    {
    }
}
