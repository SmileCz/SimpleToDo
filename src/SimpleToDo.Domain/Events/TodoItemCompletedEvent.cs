namespace SimpleToDo.Core.Events;

public class TodoItemCompletedEvent : BaseTodoItemEvent
{
    public TodoItemCompletedEvent(ToDoItem item) : base(item)
    {
    }
}