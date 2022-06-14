

namespace SimpleToDo.Core.Events;

public class TodoItemCreatedEvent : BaseTodoItemEvent
{
    public TodoItemCreatedEvent(TodoItem item) : base(item)
    {
    }
}