namespace OMG.Domain.Base;

public abstract class Entity
{
    public Guid Id { get; }


    public Entity() => Id = Guid.NewGuid();

    public Entity(Guid id) => Id = id;
}

