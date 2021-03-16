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
    public class ClientAppService_Tests : SalonsApplicationTestBase
    {
        private readonly IClientAppService _clientAppService;
        public ClientAppService_Tests(IClientAppService clientAppService)
        {
            _clientAppService = clientAppService;
        }

        [Fact]
        public async Task Should_Get_List_Of_Clients()
        {
            //Act
            var result = await _clientAppService.GetListAsync(new PagedAndSortedResultRequestDto());

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(x => x.FirstName == "Test");
            result.Items.ShouldContain(x => x.LastName == "Client");
        }
        [Fact]
        public async Task Should_Get_Single_Client()
        {
            //Act
            var result = await _clientAppService.GetAsync(1);

            //Assert
            result.ShouldNotBeNull();
        }
        [Fact]
        public async Task Should_Create_A_Valid_Client()
        {
            //Act
            var result = await _clientAppService.CreateAsync(
                new CreateUpdateClientDto
                {
                    FirstName = "Demo",
                    LastName = "Client",
                    Code = "WALKIN",
                    CategoryId = 1,
                    EmailAddress = "demo@testclient.com",
                    MobileNumber = "+2781758964"
                }
            );

            //Assert
            result.Id.ShouldNotBe(0);
            result.EmailAddress.ShouldBe("demo@testclient.com");
        }
        [Fact]
        public async Task Should_Not_Create_A_Client_Without_Name()
        {
            var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
            {
                await _clientAppService.CreateAsync(
                     new CreateUpdateClientDto
                     {
                         FirstName = "",
                         LastName = "",
                         Code = "WALKIN",
                         CategoryId = 1,
                         EmailAddress = "demo@testclient.com",
                         MobileNumber = "+2781758964"
                     }
                );
            });

            exception.ValidationErrors
                .ShouldContain(err => err.MemberNames.Any(mem => mem == "FirstName"));
        }
    }
}
