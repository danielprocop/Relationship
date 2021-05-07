using System;
using System.Collections.Generic;

namespace PLDP.Relationship.Person
{

    public class GetListOfPersonQueryHandler
    {
        private readonly List<Person> _people = new List<Person>()
        {
            new Person(1,"Adrian","Procop",new DateTime(1992,6,8)),
            new Person(1,"Irina","Bucsa",new DateTime(1996,1,15)),
            new Person(1,"Andy","Simota",new DateTime(1997,9,3))
        };

        public List<Person> Handle()
        {
            return _people;
        }
    }
}
