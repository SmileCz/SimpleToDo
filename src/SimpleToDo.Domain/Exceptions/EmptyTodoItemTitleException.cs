using SimpleToDo.Shared.Abstraction.Exceptions;

namespace SimpleToDo.Domain.Exceptions;

public class EmptyTodoItemTitleException : SimpleToDoException

{
    public EmptyTodoItemTitleException()
    :base("Todo Item Title is empty")
    { 
        
    }
}