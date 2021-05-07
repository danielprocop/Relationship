using PLDP.Relationship.Core;

namespace PLDP.Relationship.Person
{
    public class Contact: Entity
    {
        public string Value { get; set; }
        public ContactType Type { get; set; }
    }
}