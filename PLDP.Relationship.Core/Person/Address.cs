using PLDP.Relationship.Core;

namespace PLDP.Relationship.Person
{
    public class Address:Entity
    {
        public string Description { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string CityName { get; set; }
        public string Province { get; set; }
        public string CountryAlpha2Code { get; set; }
        public string Country { get; set; }

    }
}