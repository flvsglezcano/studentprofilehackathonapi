//using Azure.Data.Tables;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using GraphQL;

namespace GraphQL_AzureFunction1.Types
{
    public class StudentEntity : ITableEntity
    {
        
        public int Id { get; set; } = default!;
        public string? FirstName { get; set; } = default!;
        public string? LastName { get; set; } = default!;
        public Int32? Grade { get; set; } = default!;
        public DateTime? DateOfBirth { get; set; }   
        public AddressEntity? Address { get; set; }
        public PhoneEntity? Phone { get; set; }
        public string PartitionKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RowKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTimeOffset Timestamp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ETag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ReadEntity(IDictionary<string, EntityProperty> properties, OperationContext operationContext)
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, EntityProperty> WriteEntity(OperationContext operationContext)
        {
            throw new NotImplementedException();
        }
    }
}
