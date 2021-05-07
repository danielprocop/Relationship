using PLDP.Relationship.Core;
using System;
using System.Collections.Generic;

namespace PLDP.Relationship.Person
{
    public class Meeting:Entity
    {
        public DateTime MeetingDate { get; set; }
        public bool AlreadyBeen { get; set; }
        public MeetingAddress Location { get; set; }
        public MeetingType MeetingType { get; set; }
        public bool WasScheduled { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public MeetingPriority MeetingPriority { get; set; }
        public List<Person> OtherParticipants { get; set; }   
    }
}