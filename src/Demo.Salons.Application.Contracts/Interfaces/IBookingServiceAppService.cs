using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo.Salons.Salons
{
    public interface IBookingServiceAppService :
        ICrudAppService< //Defines CRUD methods
            BookingServiceDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookingServiceDto> //Used to create/update a entity
    {
    }
}
