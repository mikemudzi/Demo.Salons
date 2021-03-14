using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo.Salons.Salons
{
    public class EmployeeAppService :
        CrudAppService<
            Employee, //The entity
            EmployeeDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateEmployeeDto>, //Used to create/update a entity
        IEmployeeAppService //implement the I<Entity>AppService
    {
        public EmployeeAppService(IRepository<Employee, long> repository)
          : base(repository)
        {

        }
    }
}
