namespace SimpleToDo.Core.Events;

public class TodoItemDeletedEvent : BaseTodoItemEvent
{
    public TodoItemDeletedEvent(ToDoItem item) : base(item)
    {
    }
}