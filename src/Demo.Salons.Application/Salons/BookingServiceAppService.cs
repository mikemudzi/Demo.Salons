using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo.Salons.Salons
{
    public class BookingServiceAppService :
        CrudAppService<
            BookingService, //The entity
            BookingServiceDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookingServiceDto>, //Used to create/update a entity
        IBookingServiceAppService //implement the I<Entity>AppService
    {
        public BookingServiceAppService(IRepository<BookingService, long> repository)
          : base(repository)
        {

        }
    }
}
