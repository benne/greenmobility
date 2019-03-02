namespace BenneIO.GreenMobility.Models
{
    public class Address
    {
        public Address(string streetAddress, string locality, string postalCode, string region, string country)
        {
            StreetAddress = streetAddress;
            Locality = locality;
            PostalCode = postalCode;
            Region = region;
            Country = country;
        }

        public string StreetAddress { get; }

        public string Locality { get; }

        public string PostalCode { get; }

        public string Region { get; }

        public string Country { get; }
    }
}