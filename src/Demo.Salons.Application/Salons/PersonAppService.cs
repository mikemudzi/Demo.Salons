using System;
using Demo.Salons.Salons;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo.Salons.Salons
{
    public class PersonAppService :
        CrudAppService<
            Person, //The entity
            PersonDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdatePersonDto>, //Used to create/update a entity
        IPersonAppService //implement the I<Entity>AppService
    {
        public PersonAppService(IRepository<Person, long> repository)
           : base(repository)
        {

        }
    }
}
