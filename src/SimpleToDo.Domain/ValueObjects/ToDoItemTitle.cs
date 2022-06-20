using SimpleToDo.Core.Exceptions;

namespace SimpleToDo.Core.ValueObjects;

public record ToDoItemTitle
{
    public ToDoItemTitle(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyTodoItemTitleException();
        }
        Value = value;
    }

    public string Value { get; }
}