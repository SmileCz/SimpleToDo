namespace SimpleToDo.Core.ValueObjects;

internal record ToDoItemNote {
    public ToDoItemNote(string? value)
    {
        Value = value;
    }

    public string? Value { get; }
}