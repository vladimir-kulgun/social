using System.Collections.Generic;

namespace Dom.Common
{
    public abstract class Entity<TKey>
    {
        protected Entity()
        {
            Events = new List<DomainEvent>();
        }

        public TKey Id { get; }
        public ICollection<DomainEvent> Events { get; }
    }
}
