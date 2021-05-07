using System;
using System.Collections.Generic;
using System.Text;

namespace PLDP.Relationship.Core
{
    public abstract class Entity: Entity<int>
    {
        public override int Id { get; set; }
    }
    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }

    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
