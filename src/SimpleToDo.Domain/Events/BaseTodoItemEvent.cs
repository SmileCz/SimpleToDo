namespace SimpleToDo.Core.Events;

public class BaseTodoItemEvent : BaseEvent
{
    public BaseTodoItemEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}