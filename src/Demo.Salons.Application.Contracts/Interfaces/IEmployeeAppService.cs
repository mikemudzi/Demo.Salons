using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Salons.Salons
{
    public interface IEmployeeAppService :
        ICrudAppService< //Defines CRUD methods
            EmployeeDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateEmployeeDto> //Used to create/update a entity
    {
    }
}
