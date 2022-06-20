namespace SimpleToDo.Shared.Abstraction.Exceptions;

public abstract class SimpleToDoException : Exception
{
    protected SimpleToDoException(string message) : base(message)
    {
        
    }
}