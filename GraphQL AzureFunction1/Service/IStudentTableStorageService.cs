using GraphQL_AzureFunction1.AzureEntities;
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
        Task<IEnumerable<StudentGraphQLEntity>> GetAllStudentEntitiesAsync();
        Task<StudentGraphQLEntity> GetStudentEntityAsync(int id);
        Task<StudentEntity> UpsertStudentEntityAsync(StudentEntity entity);
        Task DeleteStudentEntityAsync(int id);
    }
}
