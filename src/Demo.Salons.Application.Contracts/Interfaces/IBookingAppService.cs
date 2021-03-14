using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Salons.Salons
{
    public interface IBookingAppService :
        ICrudAppService< //Defines CRUD methods
            BookingDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookingDto> //Used to create/update a entity
    {
    }
}
