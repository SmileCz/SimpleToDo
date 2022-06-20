namespace SimpleToDo.Core.Events;

public class TodoItemUndeletedEvent : BaseTodoItemEvent
{
    public TodoItemUndeletedEvent(ToDoItem item) : base(item)
    {
    }
}
