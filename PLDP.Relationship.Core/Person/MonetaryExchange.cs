using PLDP.Relationship.Core;
using System;

namespace PLDP.Relationship.Person
{
    public class MonetaryExchange:Entity
    {
        public MonetaryExchangeType MonetaryExchangeType { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public bool MustBeGivenBack { get; set; }
        public DateTime? RetunDate { get; set; }
    }
}