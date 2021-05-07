using PLDP.Relationship.Core;
using System;
using System.Collections.Generic;

namespace PLDP.Relationship.Person
{
    public class Person:Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Description { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Address> Addresses { get; set; }
        public Person(
            string name
            , string surname = null
            , string description = null
            , DateTime? dateOfBirth=null
            , List<Contact> contacts = null
            , List<Address> addresses = null)
        {
            if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(surname) && string.IsNullOrWhiteSpace(description))
                throw new InvalidOperationException("The persone must have a name or a surname or a description to be created");

            Name = name;
            Surname = surname;
            Description = description;
            DateOfBirth = dateOfBirth;
            Contacts = contacts;
            this.Addresses = addresses;
        }
    }
}
