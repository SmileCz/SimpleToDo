namespace SimpleToDo.Core.Common;

public interface IAuditableEntity
{
    public bool IsDeleted { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? LastModified { get; set; }

    public string? CreatedBy { get; set; }
    public string? LastModifiedBy { get; set; }
}