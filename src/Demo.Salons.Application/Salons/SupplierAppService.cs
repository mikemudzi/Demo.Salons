using System;
using Demo.Salons.Salons;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo.Salons.Salons
{
    public class SupplierAppService :
        CrudAppService<
            Supplier, //The entity
            SupplierDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateSupplierDto>, //Used to create/update a entity
        ISupplierAppService //implement the I<Entity>AppService
    {
        public SupplierAppService(IRepository<Supplier, long> repository)
           : base(repository)
        {

        }
    }
}
