using SimpleToDo.Shared.Abstraction.Exceptions;

namespace SimpleToDo.Domain.Exceptions;

public class WhitespaceTodoItemTitleException : SimpleToDoException
{
    public WhitespaceTodoItemTitleException() : base("Todo Item Title is whitespaces")
    {
        
    }
}