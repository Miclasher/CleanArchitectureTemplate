namespace SharedKernel;

public abstract class Entity
{
    private readonly List<IDomainEvent> _domainEvents = [];

    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    protected void Raise(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}

public abstract class Entity<TId> : Entity
{
    public TId Id { get; }

    protected Entity(TId id)
    {
        Id = id;
    }

    // For EF Core
    protected Entity()
    {
    }
}
