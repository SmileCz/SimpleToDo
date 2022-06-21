using SimpleToDo.Domain.Entities;

namespace SimpleToDo.Domain.Events;

public class TodoItemDeletedEvent : BaseTodoItemEvent
{
    public TodoItemDeletedEvent(ToDoItem item) : base(item)
    {
    }
}