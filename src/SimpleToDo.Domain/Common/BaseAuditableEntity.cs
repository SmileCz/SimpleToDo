namespace SimpleToDo.Domain.Common;

public abstract class BaseAuditableEntity<T> : BaseEntity<T>, IAuditableEntity
{
    public virtual bool IsDeleted { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? LastModified { get; set; }

    public string? CreatedBy { get; set; }
    public string? LastModifiedBy { get; set; }
}