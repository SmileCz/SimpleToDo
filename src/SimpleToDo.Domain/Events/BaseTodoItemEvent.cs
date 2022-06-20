namespace SimpleToDo.Core.Events;

public class BaseTodoItemEvent : BaseEvent
{
    public BaseTodoItemEvent(ToDoItem item)
    {
        Item = item;
    }

    public ToDoItem Item { get; }
}