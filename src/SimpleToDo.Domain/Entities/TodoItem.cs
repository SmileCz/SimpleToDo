

namespace SimpleToDo.Core.Entities;

public class TodoItem : BaseAuditableEntity
{
    private bool _archived;
    private bool _done;


    public int ListId { get; set; }

    public string? Title { get; set; }
    public string? Note { get; set; }
    public PriorityLevel Priority { get; set; }
    public DateTimeOffset Reminder { get; set; }


    public bool Done
    {
        get => _done;
        set
        {
            if (value == true && _done == false)
            {
                AddDomainEvent(new TodoItemCompletedEvent(this));
            }

            _done = value;
        }
    }

    public bool Archived
    {
        get => _archived;
        set
        {
            switch (value)
            {
                case true when _archived == false:
                    AddDomainEvent(new TodoItemArchivedEvent(this));
                    break;
                case false when _archived:
                    AddDomainEvent(new TodoItemUnarchivedEvent(this));
                    break;
            }

            _archived = value;
        }
    }
}