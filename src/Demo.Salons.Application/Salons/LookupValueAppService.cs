using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Repositories;

namespace Demo.Salons.Salons
{
    public class LookupValueAppService :
        CrudAppService<
            LookupValue, //The entity
            LookupValueDto, //Used to show entities
            long, //Primary key of the entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateLookupValueDto>, //Used to create/update a entity
        ILookupValueAppService //implement the I<Entity>AppService
    {
        private readonly IRepository<LookupType, long> _lookupTypeRepository;
        private readonly IRepository<LookupValue, long> _lookupValuesRepository;
        private readonly IAuditingManager _auditingManager;

        public LookupValueAppService(IRepository<LookupValue, long> repository, IRepository<LookupType, long> lookupTypeRepository,
            IRepository<LookupValue, long> lookupValuesRepository, IAuditingManager auditingManager)
            : base(repository)
        {
            _lookupTypeRepository = lookupTypeRepository;
            _lookupValuesRepository = lookupValuesRepository;
            _auditingManager = auditingManager;
        }

        private async Task<long> GetLookupTypeId(string type)
        {
            var queryable = await _lookupTypeRepository.GetQueryableAsync();

            var id = queryable.Where(x => x.type == type).FirstOrDefault().Id;

            return id;
        }

        public async Task<List<LookupValueDto>> GetLookupValuesByType(string type)
        {
            List<LookupValueDto> results = new List<LookupValueDto>();
            try
            {
                long typeid = await GetLookupTypeId(type);

                var lookupQueryable = await _lookupValuesRepository.GetQueryableAsync();

                var query = lookupQueryable.Where(x => x.LookupTypeId == typeid).OrderBy(o => o.Description);

                results = query.Select(p => new LookupValueDto
                {
                    LookupTypeId = p.LookupTypeId,
                    Description = p.Description,
                    ValueCode = p.ValueCode,
                    ValueName = p.ValueName
                }).ToList();
            }
            catch (Exception ex)
            {
                _auditingManager.Current.Log.Exceptions.Add(ex);
            }
            return results;
        }
    }
}
