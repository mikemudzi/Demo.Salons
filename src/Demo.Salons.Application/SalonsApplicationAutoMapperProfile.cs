using AutoMapper;
using Demo.Salons.Salons;

namespace Demo.Salons
{
    public class SalonsApplicationAutoMapperProfile : Profile
    {
        public SalonsApplicationAutoMapperProfile()
        {
            //Model Mapping
            CreateMap<Address, AddressDto>();
            CreateMap<Booking, BookingDto>();
            CreateMap<BookingService, BookingServiceDto>();
            CreateMap<Client, ClientDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Employee, EmployeeDto>();
            CreateMap<LookupType, LookupTypeDto>();
            CreateMap<LookupValue, LookupValueDto>();
            CreateMap<OrganisationUnit, OrganisationUnitDto>();
            CreateMap<Person, PersonDto>();
            CreateMap<Product, ProductDto>();
            CreateMap<Service, ServiceDto>();
            CreateMap<Supplier, SupplierDto>();

            //CRUDdto Mapping
            CreateMap<CreateUpdateAddressDto, Address>();
            CreateMap<CreateUpdateBookingDto, Booking>();
            CreateMap<CreateUpdateBookingServiceDto, BookingService>();
            CreateMap<CreateUpdateClientDto, Client>();
            CreateMap<CreateUpdateCountryDto, Country>();
            CreateMap<CreateUpdateEmployeeDto, Employee>();
            CreateMap<CreateUpdateLookupTypeDto, LookupType>();
            CreateMap<CreateUpdateLookupValueDto, LookupValue>();
            CreateMap<CreateUpdateOrganisationUnitDto, OrganisationUnit>();
            CreateMap<CreateUpdatePersonDto, Person>();
            CreateMap<CreateUpdateProductDto, Product>();
            CreateMap<CreateUpdateServiceDto, Service>();
            CreateMap<CreateUpdateSupplierDto, Supplier>();
        }
    }
}
