using System;
using System.Linq;
using System.Threading.Tasks;
using Shouldly;
using Demo.Salons.Salons;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using Xunit;


namespace Demo.Salons.Salons
{
    public class BookingServiceAppService_Tests : SalonsApplicationTestBase
    {
        private readonly IBookingAppService _bookingServiceAppService;
        public BookingServiceAppService_Tests(IBookingAppService bookingServiceAppService)
        {
            _bookingServiceAppService = bookingServiceAppService;
        }

        [Fact]
        public async Task Should_Get_List_Of_BookingServices()
        {
            //Act
            var result = await _bookingServiceAppService.GetListAsync(new PagedAndSortedResultRequestDto());

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
        }
        [Fact]
        public async Task Should_Get_Single_BookingService()
        {
            //Act
            var result = await _bookingServiceAppService.GetAsync(1);

            //Assert
            result.ShouldNotBeNull();
        }
        
    }
}
