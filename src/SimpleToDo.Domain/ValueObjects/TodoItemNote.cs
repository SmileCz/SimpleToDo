using SimpleToDo.Domain.Exceptions;

namespace SimpleToDo.Domain.ValueObjects;

public record TodoItemNote {
    public TodoItemNote(string? value)
    {

        if (value != null && string.IsNullOrEmpty(value))
        {
            throw new EmptyTodoItemNoteException();
        }

        if (value != null && string.IsNullOrWhiteSpace(value))
        {
            throw new WhitespaceTodoItemNoteException();
        }
        
        Value = value;
    }

    public string? Value { get; }

    public static implicit operator string?(TodoItemNote note) => note.Value;
    public static implicit operator TodoItemNote(string? note) => new(note);
}