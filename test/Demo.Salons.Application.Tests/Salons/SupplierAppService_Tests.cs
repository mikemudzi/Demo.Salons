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
    public class SupplierAppService_Tests : SalonsApplicationTestBase 
    {
        private readonly ISupplierAppService _supplierAppService;
        public SupplierAppService_Tests(ISupplierAppService supplierAppService)
        {
            _supplierAppService = supplierAppService;
        }

        [Fact]
        public async Task Should_Get_List_Of_Suppliers()
        {
            //Act
            var result = await _supplierAppService.GetListAsync(new PagedAndSortedResultRequestDto());

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(x => x.SupplierName == "Magic hair");
        }
        [Fact]
        public async Task Should_Get_Single_Supplier()
        {
            //Act
            var result = await _supplierAppService.GetAsync(1);

            //Assert
            result.ShouldNotBeNull();
        }
        [Fact]
        public async Task Should_Create_A_Valid_Supplier()
        {
            //Act
            var result = await _supplierAppService.CreateAsync(
                new CreateUpdateSupplierDto
                {
                   
                }
            );

            //Assert
            result.Id.ShouldNotBe(0);
            result.SupplierName.ShouldBe("Magic Nails");
        }
        [Fact]
        public async Task Should_Not_Create_A_Address_Without_AddressLine1()
        {
            var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
            {
                await _supplierAppService.CreateAsync(
                     new CreateUpdateSupplierDto
                     {
                         
                     }
                );
            });

            exception.ValidationErrors
                .ShouldContain(err => err.MemberNames.Any(mem => mem == "SupplierName"));
        }
    }
}
