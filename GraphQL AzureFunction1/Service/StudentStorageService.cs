using Azure.Data.Tables;
using GraphQL_AzureFunction1.AzureEntities;
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
        private const string _partition = "1";
        public StudentStorageService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task DeleteStudentEntityAsync(int id)
        {
            var tableClient = await GetTableClient();
            await tableClient.DeleteEntityAsync(_partition, id.ToString());
        }

        public async Task<IEnumerable<StudentGraphQLEntity>> GetAllStudentEntitiesAsync()
        {
            var tableClient = await GetTableClient();

            IList<StudentGraphQLEntity> studentEntities = new List<StudentGraphQLEntity>();
            var students = tableClient.QueryAsync<StudentEntity>();
            await foreach (var student in students)
            {
                studentEntities.Add(
                                new StudentGraphQLEntity
                                {
                                    Id = student.Id,
                                    DateOfBirth = student.DateOfBirth,
                                    FirstName = student.FirstName,
                                    LastName = student.LastName,
                                    Grade = student.Grade,
                                    PartitionKey = student.PartitionKey,
                                    RowKey = student.RowKey
                                });

            }
            return studentEntities;
        }

        public async Task<StudentGraphQLEntity> GetStudentEntityAsync(int id)
        {

            var tableClient = await GetTableClient();
            StudentEntity student = await tableClient.GetEntityAsync<StudentEntity>(_partition, id.ToString());
            StudentGraphQLEntity rs = new StudentGraphQLEntity{
                                    Id = student.Id,
                                    DateOfBirth = student.DateOfBirth,
                                    FirstName = student.FirstName,
                                    LastName = student.LastName,
                                    Grade = student.Grade,
                                    PartitionKey = student.PartitionKey,
                                    RowKey = student.RowKey
                                };
            return rs;
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
