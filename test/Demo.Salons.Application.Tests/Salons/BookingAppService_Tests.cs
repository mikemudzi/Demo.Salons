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
    public class BookingAppService_Tests : SalonsApplicationTestBase
    {
        private readonly IBookingAppService _bookingAppService;
        public BookingAppService_Tests(IBookingAppService bookingAppService)
        {
            IBookingAppService _bookingAppService = bookingAppService;
        }

        [Fact]
        public async Task Should_Get_List_Of_Bookings()
        {
            //Act
            var result = await _bookingAppService.GetListAsync(new PagedAndSortedResultRequestDto());

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
        }
        [Fact]
        public async Task Should_Get_Single_Booking()
        {
            //Act
            var result = await _bookingAppService.GetAsync(1);

            //Assert
            result.ShouldNotBeNull();
        }
        [Fact]
        public async Task Should_Create_A_Valid_Booking()
        {
            //Act
            var result = await _bookingAppService.CreateAsync(
                new CreateUpdateBookingDto
                {
                   BookingDateAndTime = DateTime.Now,
                   ClientId = 1,
                   EmployeeId = 1,
                   ServiceId = 1
                }
            );

            //Assert
            result.Id.ShouldNotBe(0);
           
        }
        [Fact]
        public async Task Should_Not_Create_A_Address_Without_BookingDate()
        {
            var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
            {
                await _bookingAppService.CreateAsync(
                     new CreateUpdateBookingDto
                     {
                         ClientId = 1,
                         EmployeeId = 2,
                         ServiceId  = 3
                     }
                );
            });

            exception.ValidationErrors
                .ShouldContain(err => err.MemberNames.Any(mem => mem == "BookingDateAndTime"));
        }
    }
}
