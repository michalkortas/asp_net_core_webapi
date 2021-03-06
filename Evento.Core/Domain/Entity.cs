using System;

namespace Evento.Core.Domain
{
    public abstract class Entity
    {
        public Guid Id {get; set;}

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}