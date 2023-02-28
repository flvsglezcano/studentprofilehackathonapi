﻿using Azure.Data.Tables;
using System;
using GraphQL;
using Azure;

namespace GraphQL_AzureFunction1.Types
{
    public class StudentGraphQLEntity
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
    }
}
