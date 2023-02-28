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

        public Task<List<StudentEntity>> GetAllStudentEntitiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StudentEntity> GetStudentEntityAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StudentEntity> UpsertStudentEntityAsync(StudentEntity entiry)
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
