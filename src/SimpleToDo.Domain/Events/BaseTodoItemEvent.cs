using SimpleToDo.Domain.Common;
using SimpleToDo.Domain.Entities;

namespace SimpleToDo.Domain.Events;

public class BaseTodoItemEvent : BaseEvent
{
    public BaseTodoItemEvent(ToDoItem item)
    {
        Item = item;
    }

    public ToDoItem Item { get; }
}