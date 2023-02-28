using GraphQL;

namespace GraphQL_AzureFunction1
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Int32? Grade { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Address? Address { get; set; }
        public Phone? Phone { get; set; }

    }
}
