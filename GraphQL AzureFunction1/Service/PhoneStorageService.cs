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
    public class PhoneStorageService : IPhoneTableStorageService
    {
        private const string TableName = "Phone";
        private readonly IConfiguration _configuration;
        public PhoneStorageService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task DeletePhoneEntityAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PhoneEntity>> GetAllPhoneEntitiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PhoneEntity> GetPhoneEntityAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PhoneEntity> UpsertPhoneEntityAsync(PhoneEntity entity)
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
