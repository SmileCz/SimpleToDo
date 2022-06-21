

using SimpleToDo.Domain.Common;
using SimpleToDo.Domain.Enums;
using SimpleToDo.Domain.Events;
using SimpleToDo.Domain.ValueObjects;

namespace SimpleToDo.Domain.Entities;

public class ToDoItem : BaseAuditableEntity<int>
{
    private bool _done;
    private bool _isDeleted;
    private int _listId;
    private TodoItemNote _note;
    private PriorityLevel _priorityLevel;
    private DateTimeOffset _reminder;
    private TodoItemTitle _title;

    internal ToDoItem(int listId,TodoItemTitle title, TodoItemNote note, PriorityLevel priorityLevel, DateTimeOffset reminder)
    {
        _listId = listId;
        _title = title;  
        _note = note;
        _priorityLevel = priorityLevel;
        _reminder = reminder;
    }


    public bool Done
    {
        get => _done;
        set
        {
            if (value && _done == false)
            {
                AddDomainEvent(new TodoItemCompletedEvent(this));
            }

            _done = value;
        }
    }

    public override bool IsDeleted
    {
        get => _isDeleted;
        set
        {
            switch (value)
            {
                case true when _isDeleted == false:
                    AddDomainEvent(new TodoItemDeletedEvent(this));
                    break;
                case false when _isDeleted:
                    AddDomainEvent(new TodoItemUndeletedEvent(this));
                    break;
            }

            _isDeleted = value;
        }
    }
}