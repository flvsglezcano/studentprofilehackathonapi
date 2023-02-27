namespace GraphQL_AzureFunction1
{
    public class Address
    {
        public int Id { get; set; } = default!;
        public string AddressLine1 { get; set; } = default!;
        public string AddressLine2 { get; set; } = default!;
        public string City { get; set; } = default!;
        public string State { get; set; } = default!;
        public string ZipCode { get; set; } = default!;
        public string Country { get; set; } = default!;
    }
}
