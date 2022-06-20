using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleToDo.Core.Common;

public abstract class BaseEntity<T>
{
    private readonly List<BaseEvent> _domainEvents = new();

    public virtual T Id { get; set; }

    [NotMapped] 
    public ReadOnlyCollection<BaseEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void AddDomainEvent(BaseEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void RemoveDomainEvent(BaseEvent domainEvent)
    {
        _domainEvents.Remove(domainEvent);
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}