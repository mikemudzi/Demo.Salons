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
    public class LookupTypeAppService_Tests : SalonsApplicationTestBase
    {
        private readonly IAddressAppService _addressAppService;
        public AddressAppService_Tests(IAddressAppService addressAppService)
        {
            _addressAppService = addressAppService;
        }

        [Fact]
        public async Task Should_Get_List_Of_Addresses()
        {
            //Act
            var result = await _addressAppService.GetListAsync(new PagedAndSortedResultRequestDto());

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(x => x.AddressLine1 == "41 17 On Forest");
        }
        [Fact]
        public async Task Should_Get_Single_Address()
        {
            //Act
            var result = await _addressAppService.GetAsync(1);

            //Assert
            result.ShouldNotBeNull();
        }
        [Fact]
        public async Task Should_Create_A_Valid_Address()
        {
            //Act
            var result = await _addressAppService.CreateAsync(
                new CreateUpdateAddressDto
                {
                    AddressLine1 = "13 Londolozi street",
                    AddressLine2 = "Meadow Ridge",
                    Surburb = "Moreleta Park",
                    City = "Pretoria",
                    PostalCode = "2061"

                }
            );

            //Assert
            result.Id.ShouldNotBe(0);
            result.AddressLine1.ShouldBe("13 Londolozi street");
        }
        [Fact]
        public async Task Should_Not_Create_A_Address_Without_AddressLine1()
        {
            var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
            {
                await _addressAppService.CreateAsync(
                     new CreateUpdateAddressDto
                     {
                         AddressLine1 = "",
                         AddressLine2 = "Test Address"
                     }
                );
            });

            exception.ValidationErrors
                .ShouldContain(err => err.MemberNames.Any(mem => mem == "AddressLine1"));
        }
    }
}
