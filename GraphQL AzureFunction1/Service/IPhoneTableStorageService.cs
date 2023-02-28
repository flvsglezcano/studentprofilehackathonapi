using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL_AzureFunction1.Types;

namespace GraphQLSPP.Service
{
    public interface IPhoneTableStorageService
    {
        Task<List<PhoneEntity>> GetAllPhoneEntitiesAsync();
        Task<PhoneEntity> GetPhoneEntityAsync(int id);
        Task<PhoneEntity> UpsertPhoneEntityAsync(PhoneEntity entity);
        Task DeletePhoneEntityAsync(int id);
    }
}
