using System;

namespace GraphQL_AzureFunction1
{
    public class Student
    {
        public int Id { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public int Grade { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }   
    }
}
