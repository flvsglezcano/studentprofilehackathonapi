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
    public class StudentStorageService : IStudentTableStorageService
    {
        private const string TableName = "Student";
        private readonly IConfiguration _configuration;
        public StudentStorageService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task DeleteStudentEntityAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StudentEntity>> GetAllStudentEntitiesAsync()
        {
            var tableClient = await GetTableClient();
            return await tableClient.GetEntityAsync<StudentEntity>(1);
        }

        public async Task<StudentEntity> GetStudentEntityAsync(string rowKey)
        {
            var tableClient = await GetTableClient();
            return await tableClient.GetEntityAsync<StudentEntity>("1", rowKey);
        }

        public async Task<StudentEntity> UpsertStudentEntityAsync(StudentEntity entity)
        {
            var tableClient = await GetTableClient();
            object value = await tableClient.UpsertEntityAsync(entity);
            return entity;
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
