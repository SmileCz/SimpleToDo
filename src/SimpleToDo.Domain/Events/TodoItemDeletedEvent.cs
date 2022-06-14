namespace SimpleToDo.Core.Events;

public class TodoItemDeletedEvent : BaseTodoItemEvent
{
    public TodoItemDeletedEvent(TodoItem item) : base(item)
    {
    }
}