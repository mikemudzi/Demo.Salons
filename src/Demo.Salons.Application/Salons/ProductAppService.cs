using System;
using Demo.Salons.Salons;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo.Salons.Salons
{
    public class ProductAppService :
        CrudAppService<
            Product, //The entity
            ProductDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateProductDto>, //Used to create/update a entity
        IProductAppService //implement the I<Entity>AppService
    {
        public ProductAppService(IRepository<Product, long> repository)
           : base(repository)
        {

        }
    }
}
