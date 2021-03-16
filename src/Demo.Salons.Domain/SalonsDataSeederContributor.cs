using System;
using System.Threading.Tasks;
using Demo.Salons.Salons;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Demo.Salons
{
    public class SalonsDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Address, long> _addressRepository;
        private readonly IRepository<Booking, long> _bookingRepository;
        private readonly IRepository<BookingService, long> _bookingServiceRepository;
        private readonly IRepository<Client, long> _clientRepository;
        private readonly IRepository<Country, long> _countryRepository;
        private readonly IRepository<Employee, long> _employeeRepository;
        private readonly IRepository<LookupType, long> _lookupTypeRepository;
        private readonly IRepository<LookupValue, long> _lookupValueRepository;
        private readonly IRepository<OrganisationUnit, long> _organisationUnitRepository;
        private readonly IRepository<Person, long> _personRepository;
        private readonly IRepository<Product, long> _productRepository;        
        private readonly IRepository<Service, long> _serviceRepository;
        private readonly IRepository<Supplier, long> _supplierRepository;


        public SalonsDataSeederContributor(
            IRepository<Address, long> addressRepository,
            IRepository<Booking, long> bookingRepository,
            IRepository<BookingService, long> bookingServiceRepository,
            IRepository<Client, long> clientRepository,
            IRepository<Country, long> countryRepository,
            IRepository<Employee, long> employeeRepository,
            IRepository<LookupType, long> lookupTypeRepository,
            IRepository<LookupValue, long> lookupValueRepository,
            IRepository<OrganisationUnit, long> organisationUnitRepository,
            IRepository<Person, long> personRepository,
            IRepository<Product, long> productRepository,
            IRepository<Service, long> serviceRepository,
            IRepository<Supplier, long> supplierRepository )
        {
            _addressRepository = addressRepository;
            _bookingRepository = bookingRepository;
            _bookingServiceRepository = bookingServiceRepository;
            _clientRepository = clientRepository;
            _countryRepository = countryRepository;
            _employeeRepository = employeeRepository;
            _lookupTypeRepository = lookupTypeRepository;
            _lookupValueRepository = lookupValueRepository;
            _organisationUnitRepository = organisationUnitRepository;
            _personRepository = personRepository;
            _productRepository = productRepository;
            _serviceRepository = serviceRepository;
            _supplierRepository = supplierRepository;
        }

        public async Task SeedAddresses()
        {
            if (await _addressRepository.GetCountAsync() <= 0)
            {
                await _addressRepository.InsertAsync(
                    new Address
                    {

                    },
                    autoSave: true
                );

            }
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            

            if (await _commandRepository.GetCountAsync() <= 0)
            {
                await _commandRepository.InsertAsync(
                    new Command
                    {
                        CommandName = "dt.request",
                        FriendlyName = "Downtime Request",
                        CommandType = "Direct Command"
                    },
                    autoSave: true
                );
                await _commandRepository.InsertAsync(
                    new Command
                    {
                        CommandName = "geo.request",
                        FriendlyName = "Polygon Request",
                        CommandType = "Direct Command"
                    },
                    autoSave: true
                );
                await _commandRepository.InsertAsync(
                    new Command
                    {
                        CommandName = "hourmeter.seconds",
                        FriendlyName = "Set hour meter",
                        CommandType = "Set Command"
                    },
                    autoSave: true
                );
                await _commandRepository.InsertAsync(
                    new Command
                    {
                        CommandName = "geo.clear.entry",
                        FriendlyName = "Clear Geofence Area",
                        CommandType = "Set Command"
                    },
                    autoSave: true
                );
                await _commandRepository.InsertAsync(
                    new Command
                    {
                        CommandName = "heartbeat.min",
                        FriendlyName = "Device Heartbeat",
                        CommandType = "GSM Command"
                    },
                    autoSave: true
                );
                await _commandRepository.InsertAsync(
                    new Command
                    {
                        CommandName = "sem.config",
                        FriendlyName = "sem.config",
                        CommandType = "GSM Command"
                    },
                    autoSave: true
                );
            }

            if (await _settingRepository.GetCountAsync() <= 0)
            {
                await _settingRepository.InsertAsync(
                    new Setting
                    {
                        SettingName = "DeviceHiveCommandUrl",
                        Description = "Authourization token for DeviceHive",
                        SettingValue = "d2MTYW1iiEiNaIVm9rf8SUviFS+ZbIghuO1iyJGhjqM="
                    },
                    autoSave: true
                );
                await _settingRepository.InsertAsync(
                    new Setting
                    {
                        SettingName = "DeviceHiveCommandUrl",
                        Description = "The url to device commands endpoint",
                        SettingValue = "http://api.vsvt.co.za/device/<deviceid>/command"
                    },
                     autoSave: true
                    );
            }
        }
    }
}
