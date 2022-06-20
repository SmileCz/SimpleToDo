

namespace SimpleToDo.Core.Events;

public class TodoItemCreatedEvent : BaseTodoItemEvent
{
    public TodoItemCreatedEvent(ToDoItem item) : base(item)
    {
    }
}