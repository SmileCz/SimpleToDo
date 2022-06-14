namespace SimpleToDo.Core.Events;

public class TodoItemUnarchivedEvent : BaseTodoItemEvent
{
    public TodoItemUnarchivedEvent(TodoItem item) : base(item)
    {
    }
}
