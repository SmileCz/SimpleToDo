namespace SimpleToDo.Core.Events;

public class TodoItemCompletedEvent : BaseTodoItemEvent
{
    public TodoItemCompletedEvent(TodoItem item) : base(item)
    {
    }
}