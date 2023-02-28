using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;

namespace GraphQL_AzureFunction1.Types
{
    public class AddressEntity : ITableEntity
    {
        public Int32 Id { get; set; } = default!;
        public string? AddressLine1 { get; set; } = default!;
        public string? AddressLine2 { get; set; } = default!;
        public string? City { get; set; } = default!;
        public string? State { get; set; } = default!;
        public string? ZipCode { get; set; } = default!;
        public string? Country { get; set; } = default!;
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
