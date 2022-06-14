namespace SimpleToDo.Core.Events;

public class TodoItemArchivedEvent : BaseTodoItemEvent
{
    public TodoItemArchivedEvent(TodoItem item) : base(item)
    {
    }
}