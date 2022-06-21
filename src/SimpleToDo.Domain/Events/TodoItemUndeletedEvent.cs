using SimpleToDo.Domain.Entities;

namespace SimpleToDo.Domain.Events;

public class TodoItemUndeletedEvent : BaseTodoItemEvent
{
    public TodoItemUndeletedEvent(ToDoItem item) : base(item)
    {
    }
}
