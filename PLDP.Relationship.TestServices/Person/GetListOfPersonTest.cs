using PLDP.Relationship.Person;
using System;
using Xunit;

namespace PLDP.Relationship.TestServices
{
    public class GetListOfPersonTest
    {
        [Fact]
        public void GetAllListOfPersonRetunThreElements()
        {
            var sut = new GetListOfPersonQueryHandler();

            var persons = sut.Handle();

            Assert.Equal(3, persons.Count);
        }
    }
}
