using SimpleToDo.Domain.Entities;

namespace SimpleToDo.Domain.Events;

public class TodoItemCompletedEvent : BaseTodoItemEvent
{
    public TodoItemCompletedEvent(ToDoItem item) : base(item)
    {
    }
}