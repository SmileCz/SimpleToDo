using SimpleToDo.Domain.Exceptions;

namespace SimpleToDo.Domain.ValueObjects;

public record TodoItemTitle
{
    public TodoItemTitle(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new EmptyTodoItemTitleException();
        }

        if (string.IsNullOrWhiteSpace(value))
        {
            throw new WhitespaceTodoItemTitleException();
        }
        
        Value = value;
    }

    public string Value { get; }

    public static implicit operator string(TodoItemTitle title) => title.Value;
    public static implicit operator TodoItemTitle(string title) => new(title);
}