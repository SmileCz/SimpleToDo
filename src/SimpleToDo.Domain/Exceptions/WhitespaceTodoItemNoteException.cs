using SimpleToDo.Shared.Abstraction.Exceptions;

namespace SimpleToDo.Domain.Exceptions;

public class WhitespaceTodoItemNoteException : SimpleToDoException
{
    public WhitespaceTodoItemNoteException() : base("Todo Item Note is whitespaces")
    {
        
    }
}