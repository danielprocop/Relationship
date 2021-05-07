using PLDP.Relationship.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace PLDP.Relationship.Person
{
    public class RelationShip:Entity
    {
        public Person Person { get; set; }
        public DateTime? RelationshipStartDate { get; set; }
        public RelationType RelationType { get; set; }
        public List<Meeting> Meetings { get; set; }

        public List<FOS> FOSs { get; set; }

    }
}
