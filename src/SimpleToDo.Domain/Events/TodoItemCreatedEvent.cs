using SimpleToDo.Domain.Entities;

namespace SimpleToDo.Domain.Events;

public class TodoItemCreatedEvent : BaseTodoItemEvent
{
    public TodoItemCreatedEvent(ToDoItem item) : base(item)
    {
    }
}