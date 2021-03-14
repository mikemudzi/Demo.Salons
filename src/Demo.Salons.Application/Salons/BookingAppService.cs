using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo.Salons.Salons
{
    public class BookingAppService :
        CrudAppService<
            Booking, //The entity
            BookingDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookingDto>, //Used to create/update a entity
        IBookingAppService //implement the I<Entity>AppService
    {
        public BookingAppService(IRepository<Booking, long> repository)
          : base(repository)
        {

        }
    }
}
