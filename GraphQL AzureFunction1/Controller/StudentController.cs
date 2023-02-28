using GraphQL_AzureFunction1.Types;
using GraphQLSPP.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLSPP.Controller
{
    public class StudentController : ControllerBase
    {
        private readonly IStudentTableStorageService _storageService;
        public StudentController(IStudentTableStorageService storageService)
        {
            _storageService = storageService ?? throw new ArgumentNullException(nameof(storageService));
        }

        [HttpGet]
        [ActionName(nameof(GetAsync))]
        public async Task<IActionResult> GetAsync([FromQuery] int id)
        {
            return Ok(await _storageService.GetStudentEntityAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] StudentEntity entity)
        {
            entity.PartitionKey = entity.PartitionKey;
            //string Id = Guid.NewGuid().ToString();
            //entity.Id = Id;
            //entity.RowKey = Id;
            var createdEntity = await _storageService.UpsertStudentEntityAsync(entity);
            return CreatedAtAction(nameof(GetAsync), createdEntity);
        }
        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] StudentEntity entity)
        {
            entity.PartitionKey = entity.PartitionKey;
            entity.RowKey = entity.RowKey;
            await _storageService.UpsertStudentEntityAsync(entity);
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromQuery] int id)
        {
            await _storageService.DeleteStudentEntityAsync(id);
            return NoContent();
        }
    }
}
