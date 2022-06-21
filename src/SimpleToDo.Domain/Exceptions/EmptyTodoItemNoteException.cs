using SimpleToDo.Shared.Abstraction.Exceptions;

namespace SimpleToDo.Domain.Exceptions;

public class EmptyTodoItemNoteException : SimpleToDoException
{
    public EmptyTodoItemNoteException() :base("Todo Item Note is empty")
    {
    }
}