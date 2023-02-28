using Azure.Data.Tables;
using GraphQL_AzureFunction1.Types;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLSPP.Service
{
    public class AddressStorageService : IAddressTableStorageService
    {
        private const string TableName = "Address";
        private readonly IConfiguration _configuration;
        public AddressStorageService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task DeleteStudentEntityAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AddressEntity> GetAddressEntityAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AddressEntity>> GetAllAddressEntitiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AddressEntity> UpsertAddressEntityAsync(AddressEntity entity)
        {
            throw new NotImplementedException();
        }

        private async Task<TableClient> GetTableClient()
        {
            var serviceClient = new TableServiceClient(_configuration["ConnectionString"]);
            var tableClient = serviceClient.GetTableClient(TableName);
            await tableClient.CreateIfNotExistsAsync();
            return tableClient;
        }
    }
}
