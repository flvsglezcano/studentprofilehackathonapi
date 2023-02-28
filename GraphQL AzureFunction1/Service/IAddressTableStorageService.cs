using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL_AzureFunction1.Types;

namespace GraphQLSPP.Service
{
    public interface IAddressTableStorageService
    { 
        Task<List<AddressEntity>> GetAllAddressEntitiesAsync();
        Task<AddressEntity> GetAddressEntityAsync(int id);
        Task<AddressEntity> UpsertAddressEntityAsync(string id);
        Task DeleteStudentEntityAsync(int id);
    }
}
