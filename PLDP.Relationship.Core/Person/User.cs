using System;
using System.Collections.Generic;
using System.Text;

namespace PLDP.Relationship.Person
{

    public class User : Person
    {
        public User(string name, string surname = null, string description = null, DateTime? dateOfBirth = null, List<Contact> contacts = null, List<Address> addresses = null) : base(name, surname, description, dateOfBirth, contacts, addresses)
        {
        }
    }
}
