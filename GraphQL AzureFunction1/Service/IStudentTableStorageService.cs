using GraphQL_AzureFunction1.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLSPP.Service
{
    public interface IStudentTableStorageService
    {
        Task<List<StudentEntity>> GetAllStudentEntitiesAsync();
        Task<StudentEntity> GetStudentEntityAsync(string partitionKey, string rowKey);
        Task<StudentEntity> UpsertStudentEntityAsync(StudentEntity entiry);
        Task DeleteStudentEntityAsync(int id);
    }
}
