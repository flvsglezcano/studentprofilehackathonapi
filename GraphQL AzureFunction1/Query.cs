using GraphQL;

namespace GraphQL_AzureFunction1
{
    public class Query
    {
        #region Dummy Data - Remove when connection to Table Storage Established
        private static List<Student> students = new List<Student>() {
          new Student(){ Id = 1, FirstName = "John", LastName = "Smith", Grade = 6, DateOfBirth = DateTime.Now},
          new Student(){ Id = 2, FirstName = "Joanna", LastName = "Smith", Grade = 12, DateOfBirth = DateTime.Now},
          new Student(){ Id = 3, FirstName = "Bill", LastName = "Nye", Grade = 10, DateOfBirth = DateTime.Now}
        };

        private static List<Phone> phones = new List<Phone>() {
          new Phone(){ Id = 1, PhoneNumber = "5555555555", PhoneType = "Home"},
          new Phone(){ Id = 2, PhoneNumber = "1234567890", PhoneType = "Mobile"},
          new Phone(){ Id = 3, PhoneNumber = "9876543210", PhoneType = "Home"}
        };

        private static List<Address> addresses = new List<Address>() {
          new Address(){ Id = 1, AddressLine1 = "1 Test St", AddressLine2 = "Ste 1", City = "Miami", State = "FL", ZipCode = "33333", Country = "US"},
          new Address(){ Id = 2, AddressLine1 = "2 Test St", AddressLine2 = "", City = "Orlando", State = "FL", ZipCode = "12345", Country = "US"},
          new Address(){ Id = 3, AddressLine1 = "3 Test St", AddressLine2 = "Ste 3", City = "Jacksonville", State = "FL", ZipCode = "00000", Country = "US"}
        };
        #endregion

        #region Student Query's
        [GraphQLMetadata("students")]
        public List<Student> GetStudents()
        {
            return students;
        }

        [GraphQLMetadata("student")]
        public Student? GetStudent(int id)
        {
            return students.SingleOrDefault(s => s.Id == id);
        }
        #endregion

        #region Phone Query's
        [GraphQLMetadata("phones")]
        public List<Phone> GetPhones()
        {
            return phones;
        }

        [GraphQLMetadata("phone")]
        public Phone? GetPhone(int id)
        {
            return phones.SingleOrDefault(s => s.Id == id);
        }
        #endregion

        #region Address Query's
        [GraphQLMetadata("addresses")]
        public List<Address> GetAddresses(int id)
        {
            return addresses;
        }

        [GraphQLMetadata("address")]
        public Address? GetAddress(int id)
        {
            return addresses.SingleOrDefault(s => s.Id == id);
        }
        #endregion
    }
}