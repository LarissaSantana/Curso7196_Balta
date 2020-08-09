using System;
using System.Diagnostics.CodeAnalysis;

namespace Todo.Domain.Entities
{
    //IEquatable - permite realizar comparações entre um ou mais objetos do mesmo tipo
    public abstract class Entity : IEquatable<Entity>
    {
        public Guid Id { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }
    }
}
